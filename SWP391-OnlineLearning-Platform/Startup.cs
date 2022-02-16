using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SWP391_OnlineLearning_Platform.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
			services.AddDbContext<OnlineLearningDbContext>(options =>
				options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"))
			);
			services.Configure<Utils.SmtpConfigurations>(Configuration);
			services.AddSingleton<Utils.SmtpHandling, Utils.SmtpHandling>();



			//services.AddIdentity<ApplicationUser, IdentityRole>()
			//	.AddEntityFrameworkStores<ApplicationDbContext>()
			//	.AddDefaultTokenProviders();

			//services.Configure<IdentityOptions>(options =>
			//{
			//	// Password settings
			//	options.Password.RequireDigit = true;
			//	options.Password.RequiredLength = 10;
			//	options.Password.RequireNonAlphanumeric = true;
			//	options.Password.RequireUppercase = false;
			//	options.Password.RequireLowercase = false;
			//	options.Password.RequiredUniqueChars = 6;

			//	// Lockout settings
			//	options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
			//	options.Lockout.MaxFailedAccessAttempts = 10;
			//	options.Lockout.AllowedForNewUsers = true;

			//	// User settings
			//	options.User.RequireUniqueEmail = true;
			//});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}
			app.UseHttpsRedirection();
			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
				);
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
