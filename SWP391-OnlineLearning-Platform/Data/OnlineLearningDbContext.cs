using Microsoft.EntityFrameworkCore;
using SWP391_OnlineLearning_Platform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Data
{
    public class OnlineLearningDbContext : DbContext
    {
        public OnlineLearningDbContext(DbContextOptions<OnlineLearningDbContext> options) : base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }


    }
}
