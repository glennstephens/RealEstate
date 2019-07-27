﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using RealEstate.Entities;
using RealEstate.Models;
using RealEstate.Services;

namespace RealEstate.Controllers
{
	[Route("admin")]
	[Authorize(Policy = "AdministratorOnly")]
	public class AdminController : Controller
	{
		public AdminController(IDataRepository repo, IFileProvider fileProvider, IHostingEnvironment env)
		{
			_repo = repo;
			_fileProvider = fileProvider;
			_env = env;
		}

		readonly IDataRepository _repo;
		readonly IFileProvider _fileProvider;
		readonly IHostingEnvironment _env;

		[HttpGet(Name = "AdminMain")]
		public IActionResult Index()
		{
			var vm = new AdminViewModel {
				ShowMasterHeader = false,
			};

			return View(vm);
		}

		[HttpGet("editproperty", Name = "NewProperty")]
		public IActionResult NewProperty()
		{
			var vm = new PropertyViewModel();
			return View("CreateOrEditProperty", vm);
		}

		[HttpGet("editproperty/{propertyId}", Name = "EditProperty")]
		public async Task<IActionResult> EditProperty(int propertyId)
		{
			var property = await _repo.GetPropertyDetails(propertyId);
			var vm = property.ToViewModel();
			return View("CreateOrEditProperty", vm);
		}

		[HttpPost("upsertproperty", Name = "UpsertProperty")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> UpsertProperty(PropertyViewModel vm)
		{
			// If an existing property is updated, we get its assets and update its
			// descriptions from what got posted from the browser.
			// We then assign the updated asset list back to the property in the viewmodel
			// and save the entire thing.
			if (vm.Property.Id != null)
			{
				var existingProperty = await _repo.GetPropertyDetails(vm.Property.Id.Value);
				if (existingProperty != null)
				{
					foreach (var assetToUpdate in vm.Property.Assets)
					{
						var existingAsset = existingProperty.Assets.FirstOrDefault(a => a.Id == assetToUpdate.Id);
						if (existingAsset != null)
						{
							existingAsset.Description = assetToUpdate.Description;
						}
					}

					vm.Property.Assets = existingProperty.Assets;
					_repo.StopTracking(existingProperty);
				}
				
			}

			await _repo.UpsertProperty(vm.Property);

			return RedirectToRoute("ShowPropertyFullDetails", new { propertyId = vm.Property.Id });
		}

		[HttpPost("deleteproperty", Name = "DeleteProperty")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteProperty(PropertyViewModel vm)
		{
			if (!ModelState.IsValid)
			{
				return View("CreateOrEditProperty", vm);
			}

			await _repo.DeleteProperty(vm.Property.Id.Value);

			return RedirectToRoute("Home");
		}

		[HttpGet("manageimages/{propertyId}", Name = "SelectImagesForUpload")]
		public async Task<IActionResult> SelectImagesForUpload(int propertyId)
		{
			var property = await _repo.GetPropertyDetails(propertyId);
			var vm = property.ToViewModel();
			return View("ManagePropertyAssets", vm);
		}

		[HttpPost("saveimages", Name = "SaveImages")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> SaveImages([FromForm] int propertyId, List<IFormFile> files)
		{
			var property = await _repo.GetPropertyDetails(propertyId);
			if(property.Assets == null)
			{
				property.Assets = new List<PropertyAsset>();
			}

			// Code to upload image if not null
			foreach (var file in files)
			{
				if (file != null || file.Length != 0)
				{
					// Create a File Info 
					var fi = new FileInfo(file.FileName);

					var newFilename = property.Id + 
						"_" +
						String.Format("{0:d}", (DateTime.Now.Ticks / 10) % 100000000) +
						fi.Extension;

					var webPath = _env.WebRootPath;
					var path = Path.Combine("", webPath + @"\assets\" + newFilename);

					// IMPORTANT: The pathToSave variable will be save on the column in the database
					var pathToSave = @"/assets/" + newFilename;

					// This stream the physical file to the allocate wwwroot/ImageFiles folder
					using (var stream = new FileStream(path, FileMode.Create))
					{
						await file.CopyToAsync(stream);
					}

					property.Assets.Add(new PropertyAsset {
						ImageUrl = pathToSave,
						PropertyId = property.Id.Value
					});
				}
			}

			await _repo.UpsertProperty(property);

			return RedirectToRoute("EditProperty", new { propertyId = property.Id });
		}

		[HttpGet("{propertyId}/{assetId}", Name = "RemoveImage")]
		public async Task<IActionResult> RemoveImage(int propertyId, int assetId)
		{
			var property = await _repo.GetPropertyDetails(propertyId);
			var assetToRemove = property.Assets.FirstOrDefault(a => a.Id == assetId);
			if (assetToRemove != null)
			{
				property.Assets.Remove(assetToRemove);
			}
			await _repo.UpsertProperty(property);

			return RedirectToRoute("EditProperty", new { propertyId = property.Id });
		}
	}
}
