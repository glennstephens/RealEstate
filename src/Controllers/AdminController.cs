using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;

namespace RealEstate.Controllers
{
	[Route("admin")]
	[Authorize(Policy = "AdministratorOnly")]
	public class AdminController : Controller
	{
		[HttpGet]
		public async Task<IActionResult> Index()
		{

			var vm = new AdminViewModel {
				ShowMasterHeader = false,
			};

			return View(vm);
		}

	}
}
