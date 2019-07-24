﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RealEstate.Models;

namespace RealEstate.Controllers
{
	[AllowAnonymous]
	public class AccountController : Controller
	{
		[HttpGet]
		[Route("login")]
		public IActionResult Login()
		{
			var vm = new AccountViewModel {
				ShowMasterHeader = false,
			};

			return View(vm);
		}

		[HttpPost]
		[Route("login")]
		public async Task<IActionResult> Login(string userName, string password, string returnUrl = null)
		{
			if (!string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
			{
				return RedirectToAction("Login", new AccountViewModel());
			}

			//Check the user name and password  
			//Here can be implemented checking logic from the database  

			if (userName == "Admin" && password == "password")
			{
				const string Issuer = "https://realestate.com";
				var claims = new List<Claim>();
				claims.Add(new Claim(ClaimTypes.Name, "barry", ClaimValueTypes.String, Issuer));
				claims.Add(new Claim(ClaimTypes.Role, "Administrator", ClaimValueTypes.String, Issuer));

				var userIdentity = new ClaimsIdentity("SuperSecureLogin");
				userIdentity.AddClaims(claims);
				var userPrincipal = new ClaimsPrincipal(userIdentity);

				await HttpContext.SignInAsync(
					CookieAuthenticationDefaults.AuthenticationScheme,
					userPrincipal,
					new AuthenticationProperties {
						ExpiresUtc = DateTime.UtcNow.AddMinutes(20),
						IsPersistent = false,
						AllowRefresh = false
					});

				return RedirectToLocal(returnUrl);
			}

			return View();
		}

		[HttpGet]
		[Route("logout")]
		public IActionResult Logout()
		{
			var login = HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
			return RedirectToAction("Index", "Home");
		}


		private IActionResult RedirectToLocal(string returnUrl)
		{
			if (Url.IsLocalUrl(returnUrl))
			{
				return Redirect(returnUrl);
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}
		}

		public IActionResult Forbidden()
		{
			return View();
		}
	}
}