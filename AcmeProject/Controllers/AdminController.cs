using ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace AcmeProject.Controllers
{
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
