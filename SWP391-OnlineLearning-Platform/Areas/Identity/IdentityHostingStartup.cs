using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SWP391_OnlineLearning_Platform.Areas.Identity.Data;
using SWP391_OnlineLearning_Platform.LoginData;

[assembly: HostingStartup(typeof(SWP391_OnlineLearning_Platform.Areas.Identity.IdentityHostingStartup))]
namespace SWP391_OnlineLearning_Platform.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SWP391_OnlineLearning_PlatformContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SWP391_OnlineLearning_PlatformContextConnection")));

                services.AddDefaultIdentity<UserLogin>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SWP391_OnlineLearning_PlatformContext>();
            });
        }
    }
}