using ClassLibrary;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace AcmeProject.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {



        private readonly AppDbContext _appDbContext;



        public AdminController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        [HttpGet]
        public IActionResult GetSubmission()
        {
            var submissions = _appDbContext.SubmissionModels.ToList();
            return View(submissions);
        }
    }
}
