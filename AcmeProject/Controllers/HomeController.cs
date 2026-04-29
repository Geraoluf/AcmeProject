using AcmeProject.Models;
using ClassLibrary;
using DataClassLibary.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AcmeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext _appDbContext;

        private readonly SubmissionService _submissionService;


        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext, SubmissionService submissionService)
        {
            _logger = logger;
            _appDbContext = appDbContext;
            _submissionService = submissionService;
        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddSubmissionForm(SubmissionViewModel model)
        {
            if (model.Age < 18)
            {
                return View("Error");
            }

            var submission = new SubmissionModel
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Email = model.Email,
                Age = model.Age,
                SerialNumber = model.SerialNumber,
            };

            var result = _submissionService.Submit(submission);

            if (result == "ok")
            {
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", result);
            return View("privacy");
        }





        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
