using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;

namespace RealEstate.Controllers
{
	[AllowAnonymous]
	public class AccountController : Controller
	{
		[HttpGet("login", Name = "ShowLogin")]
		public IActionResult Login()
		{
			// TODO
			throw new NotImplementedException();
		}

		
		[HttpGet("logout", Name = "Logout")]
		public IActionResult Logout()
		{
			// TODO
			throw new NotImplementedException();
		}

		[HttpGet("forbidden")]
		public IActionResult Forbidden()
		{
			return View(new AccountViewModel());
		}
	}
}