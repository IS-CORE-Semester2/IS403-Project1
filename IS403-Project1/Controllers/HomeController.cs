using IS403_Project1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IS403_Project1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Home Page 
        public IActionResult Index()
        {
            return View();
        }

        //Sign Up Page Showing Available Times
        public IActionResult Availability()
        {
            return View();
        }

        //Sign Up Page FORM GET
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }


        //COMMENTED OUT UNTIL THE CORRECT FORMS AND OBJECTS ARE CREATED THAT WILL ALLOW ME TO PASS IN THE INFO I 
        ////Sign Up Page FORM POST
        //[HttpPost]
        //public IActionResult SignUp(SignUpInfo oSignUpInfo) //I NEED TO PUT IN THE CORRECT ROUTE FOR THE MODEL BEFORE THIS WILL WORK
        //{
        //    //don't submit the form unless everything has been inputted correctly.
        //    if (ModelState.IsValid)
        //    {
        //        return View("Index");
        //    }
        //    //if incorrect, just send them the form page again
        //    return View();
        //}

        //View Appointments Page
        public IActionResult Appointments()
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
