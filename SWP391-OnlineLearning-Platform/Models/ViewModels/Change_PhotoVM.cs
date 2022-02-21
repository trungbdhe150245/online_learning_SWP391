using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWP391_OnlineLearning_Platform.Models.ViewModels
{
    public class Change_PhotoVM
    {
        public DateTime Dob { get; set; }

        public string Avatar_Url { get; set; }
        public string Full_Name { get; set; }
        public int Id { get; set; }
        public IFormFile Photo { get; set; }
    }
}
