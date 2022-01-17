using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SWP391_OnlineLearning_Platform.Areas.Identity.Data;

namespace SWP391_OnlineLearning_Platform.LoginData
{
    public class SWP391_OnlineLearning_PlatformContext : IdentityDbContext<UserLogin>
    {
       

        public SWP391_OnlineLearning_PlatformContext(DbContextOptions<SWP391_OnlineLearning_PlatformContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
