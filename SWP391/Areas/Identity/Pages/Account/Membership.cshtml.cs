using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SWP391.Data;
using System.Threading.Tasks;

namespace SWP391.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class MembershipModel : PageModel
    {
        private readonly ILogger<MembershipModel> _logger;

        private readonly LearningDbContext _learningDbContext;

        public MembershipModel(ILogger<MembershipModel> logger, LearningDbContext learningDbContext)
        {
            _logger = logger;
            _learningDbContext = learningDbContext;
        }
        //public async Task<IActionResult> OnGetAsync()
        //{

        //}
    }
}
