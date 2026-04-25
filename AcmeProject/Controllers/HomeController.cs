using System.Diagnostics;
using AcmeProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace AcmeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        


        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }



        public IActionResult AddSubmissionForm(SubmissionViewModel submissionViewModel)
        {
            var add = new SubmissionViewModel
            {
                Navn = submissionViewModel.Navn,
                LastName = submissionViewModel.LastName,
                Email = submissionViewModel.Email,
                SerialNumber = submissionViewModel.SerialNumber,
            };

            

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
