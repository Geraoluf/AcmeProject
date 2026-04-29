using System.Diagnostics;
using AcmeProject.Models;
using ClassLibrary;
using Microsoft.AspNetCore.Mvc;

namespace AcmeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly AppDbContext _appDbContext;


        public HomeController(ILogger<HomeController> logger, AppDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult test()
        {
            return View();
        }



        public IActionResult AddSubmissionForm(SubmissionViewModel submissionViewModel)
        {
            var submission = new SubmissionModel
            {
                FirstName = submissionViewModel.FirstName,
                LastName = submissionViewModel.LastName,
                Email = submissionViewModel.Email,
                Age = submissionViewModel.Age,
                SerialNumber = submissionViewModel.SerialNumber,
               
            
            };

            _appDbContext.SubmissionModels.Add(submission);
            _appDbContext.SaveChanges();



            return RedirectToAction("Index");
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
