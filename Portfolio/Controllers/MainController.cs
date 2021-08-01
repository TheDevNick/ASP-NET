    using Microsoft.AspNetCore.Mvc;
    namespace Portfolio.Controllers     
    {
        public class MainController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet("/")]       //type of request
            public ViewResult Index() //this is a response to the request
            {
                return View("Index");
            }

            [HttpGet("/projects")] 

            public ViewResult Projects()
            {
               return View("Projects");
            }

            [HttpGet("/contact")]//LocalHost: 5000/contact

            public ViewResult Contact()
            {
                return View("Contact");
            }

            [HttpPost("/formresult")]
            public IActionResult FormResult(string Name, string Email, string Message)
            {
                ViewBag.name = Name;
                ViewBag.email = Email;
                ViewBag.message = Message;
                return View("FormResult");
                // Do something with form input
            }

        }
    }
