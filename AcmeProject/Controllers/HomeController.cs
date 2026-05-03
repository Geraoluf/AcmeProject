using AcmeProject.Models;
using ClassLibrary;
using DataClassLibary.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Diagnostics;

namespace AcmeProject.Controllers
{
    public class HomeController : Controller  //Controller for Submission form
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

            if (!ModelState.IsValid) return View("Index", model);


            if (model.Age < 18)
            {
                ModelState.AddModelError("Age", "Du skal være mindst 18 år");
                return View("Index", model); 
            }

            if (string.IsNullOrEmpty(model.SerialNumber)) { ModelState.AddModelError("SerialNumber", "upps du glemte at skrive et serial nummer"); return View("Index", model); }
            

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
            return View("Index", model);
        }


        public IActionResult test()
        {
            return View();
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
