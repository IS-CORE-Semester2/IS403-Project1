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
            //TO BE USED ONCE WE HAVE A VIEWMODEL THAT PASSES IN ALL OF THE APPOINTMENTS WITH AN AVAILABLE TRUE/FALSE MARKER
            //return View(new SignUpViewModel
            //{
            //    //filter appointments by availability Store it in a viewmodel and then pass it to the view
            //    AvailableAppointments = context.Appointments
            //        .Where(x => x.Available == true)
            //});

            //WHAT I'M USING FOR NOW JUST TO RETURN THE VIEW. WILL BE DELETED AND PREVIOUS SECTION WILL BE UNCOMMENTED
            return View();
        }

        //Sign Up Page FORM GET
        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }


        ////COMMENTED OUT UNTIL THE CORRECT FORMS AND OBJECTS ARE CREATED THAT WILL ALLOW ME TO PASS IN THE INFO I NEED FOR THE SIGN UP INFO
        ////Sign Up Page FORM POST
        //[HttpPost]
        //public IActionResult SignUp(SignUpInfo oSignUpInfo) //I NEED TO PUT IN THE CORRECT ROUTE FOR THE MODEL BEFORE THIS WILL WORK
        //{
        //    //don't submit the form unless everything has been inputted correctly.
        //    if (ModelState.IsValid)
        //    {
        //        //Add entry to  DB
        //        context.Tasks.Add(oSignUpInfo);
        //        //update DB
        //        context.SaveChanges();
        //        //send them back to the home page
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
