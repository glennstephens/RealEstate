using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Entities;
using RealEstate.Models;
using RealEstate.Services;

namespace RealEstate.Controllers
{
	[Route("admin")]
	[Authorize(Policy = "AdministratorOnly")]
	public class AdminController : Controller
	{
		public AdminController(IDataRepository repo)
		{
			_repo = repo;
		}

		readonly IDataRepository _repo;

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

		[HttpGet("editproperty/{id}", Name = "EditProperty")]
		public async Task<IActionResult> EditProperty(int id)
		{
			var property = await _repo.GetPropertyDetails(id);
			var vm = property.ToViewModel();
			return View("CreateOrEditProperty", vm);
		}

		[HttpPost("upsertproperty", Name = "UpsertProperty")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> UpsertProperty(PropertyViewModel vm)
		{
			if (!ModelState.IsValid)
			{
				return View("CreateOrEditProperty", vm);
			}

			// Save but keep the assets intact. We edit them separately.
			await _repo.UpsertProperty(vm.Property, overwriteAssets: false);

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
	}
}
