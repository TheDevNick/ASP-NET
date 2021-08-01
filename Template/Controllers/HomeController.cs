    using Microsoft.AspNetCore.Mvc;
    using Template.Models;
    namespace Template.Controllers     //be sure to use your own project's namespace!
    {
        public class HomeController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public IActionResult Index()
            {
                Person somePerson = new Person()
                {
                    FirstName = "Nick",
                    LastName = "Hollins",
                    Message = "This is a message"
                };


                
                return View(somePerson);
            }

            [HttpGet("/message")]
            public IActionResult Message()
            {
                
                return View(someMessage);
            }
        }


    }
