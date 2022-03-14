using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWP391.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace SWP391.Controllers
{
    public class CourseSearchController : ApiController
    {
        private readonly LearningDbContext _db;
        public CourseSearchController(LearningDbContext db)
        {
            _db = db;
        }
        public IHttpActionResult getCourseRecord()
        {
            var result = _db.Courses.ToList();
            return Ok(result);
        }
    }
}
