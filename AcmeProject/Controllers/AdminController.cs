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



        public IActionResult GetPdf()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "SerialNumbers", "serialnumbers.pdf");

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound();
            }

            var fileBytes = System.IO.File.ReadAllBytes(filePath);

            return File(fileBytes, "application/pdf", "SerialNumbers.pdf");
        }
    }
}
