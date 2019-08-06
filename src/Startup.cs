using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstate.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstate.Services;
using Microsoft.Extensions.FileProviders;
using System.IO;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

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
			// This enables the out of Personal Identifying Information (PII) in exceptions and error messages.
			// This could for example be the tenant ID of our registered app.
			// If something goes wrong it helps to see the real issue and not just "[PII hidden]" - that's why we turn it on while in debug mode.
			if (_hostingEnv.IsDevelopment())
			{
				Microsoft.IdentityModel.Logging.IdentityModelEventSource.ShowPII = true;
			}

			// Configure Azure AD.
			services
				.AddAuthentication(AzureADDefaults.AuthenticationScheme)
				.AddAzureAD(options => Configuration.Bind("AzureAd", options));

			services.Configure<OpenIdConnectOptions>(AzureADDefaults.OpenIdScheme, options =>
			{
				// The ASP.NET core templates are currently using Azure AD v1.0, and compute
				// the authority (as {Instance}/{TenantID}). We want to use the Microsoft identity platform endpoint
				options.Authority = options.Authority + "/v2.0/";

				// Set the nameClaimType to be preferred_username.
				// This change is needed because certain token claims from Azure AD v1.0 endpoint
				// (on which the original .NET core template is based) are different in Microsoft identity platform endpoint.
				// For more details see [ID Tokens](https://docs.microsoft.com/azure/active-directory/develop/id-tokens)
				// and [Access Tokens](https://docs.microsoft.com/azure/active-directory/develop/access-tokens)
				options.TokenValidationParameters.NameClaimType = "preferred_username";
			});

			services.Configure<CookieAuthenticationOptions>(AzureADDefaults.CookieScheme, options => options.AccessDeniedPath = "/forbidden");

			// Setup a policy for Administrators that we can Authorize against
			// Groups will only be included in the id_token if the manifest has been modified and "groupMembershipClaims" has been set to "All" (Security & Office 365 groups) or "SecurityGroup".
			var realEstateAdminGroupId = Configuration["RealEstateAdminGroupId"];
			services.AddAuthorization(options =>
			{
				options.AddPolicy("AdministratorOnly", policy => {
					policy.RequireClaim("groups", realEstateAdminGroupId);
				});
			});

			services.Configure<CookiePolicyOptions>(options =>
			{
				// This lambda determines whether user consent for non-essential cookies is needed for a given request.
				options.CheckConsentNeeded = context => true;
				options.MinimumSameSitePolicy = SameSiteMode.None;
			});

			services.AddDbContext<ApplicationDbContext>(
				options => options.UseSqlServer(
					Environment.GetEnvironmentVariable("UseAzureDBLiveConnection") == "true" ? Configuration.GetConnectionString("AzureDBLiveConnection") : Configuration.GetConnectionString("DefaultConnection"),
					providerOptions => providerOptions.EnableRetryOnFailure()
				));

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
