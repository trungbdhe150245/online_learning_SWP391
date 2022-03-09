using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(SWP391.Areas.Identity.IdentityHostingStartup))]
namespace SWP391.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}