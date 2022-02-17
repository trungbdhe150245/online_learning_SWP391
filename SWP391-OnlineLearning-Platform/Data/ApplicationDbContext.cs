﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore;
//using SWP391_OnlineLearning_Platform.Models;

//namespace SWP391_OnlineLearning_Platform.Data
//{
//    namespace Album.Data
//    {

//        // Kế thừa từ IdentityDbContext nên có sẵn các DbSet
//        // UserRoles Roles RoleClaimsUsers UserClaims UserLogins UserTokens
//        public class ApplicationDbContext : IdentityDbContext<User>
//        {

//            public ApplicationDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

//            protected override void OnModelCreating(ModelBuilder builder)
//            {

//                base.OnModelCreating(builder);

//                foreach (var entityType in builder.Model.GetEntityTypes())
//                {
//                    var tableName = entityType.GetTableName();
//                    if (tableName.StartsWith("AspNet"))
//                    {
//                        entityType.SetTableName(tableName.Substring(6));
//                    }
//                }
//            }

//        }
//    }
//}