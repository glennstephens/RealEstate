using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstate.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace RealEstate
{
	public class Startup
	{
		public Startup(IConfiguration configuration, IHostingEnvironment hostingEnv)
		{
			Configuration = configuration;
			_hostingEnv = hostingEnv;
		}

		readonly IHostingEnvironment _hostingEnv;
		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
					.AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
					options =>
					{
						options.LoginPath = new PathString("/Login/");
						options.AccessDeniedPath = new PathString("/Forbidden/");
					});

			// setup a policy for Administrators that we can Authorize against
			services.AddAuthorization(options =>
			{
				options.AddPolicy("AdministratorOnly", policy => policy.RequireRole("Administrator"));
			});


			services.Configure<CookiePolicyOptions>(options =>
			{
				// This lambda determines whether user consent for non-essential cookies is needed for a given request.
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});

			services.AddDbContext<ApplicationDbContext>(options =>
			{
				options.UseSqlServer(Environment.GetEnvironmentVariable("UseAzureDBLiveConnection") == "true" ? Configuration.GetConnectionString("AzureDBLiveConnection") : Configuration.GetConnectionString("DefaultConnection"));
			});

			//services.AddDefaultIdentity<IdentityUser>()
			//	.AddDefaultUI(UIFramework.Bootstrap4)
			//	.AddEntityFrameworkStores<ApplicationDbContext>();

			services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

			services.AddScoped<IDataRepository, EfDataRepository>();
			services.AddSingleton<IFileProvider>(new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/assets")));
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseDatabaseErrorPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseCookiePolicy();

			app.UseAuthentication();

			app.UseMvc();
		}
	}
}
