    using Microsoft.AspNetCore.Mvc;
    using ViewModelFun.Models;
    using System.Collections.Generic;
    namespace ViewModelFun.Controllers     //be sure to use your own project's namespace!
    {
        public class HomeController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet]       //type of request
            [Route("")]     //associated route string (exclude the leading /)
            public IActionResult Index()
            {

                return View();
            }

            [HttpGet("/numbers")]

            public IActionResult Numbers()
            {
                return View("Numbers");
            }

            [HttpGet("/users")]
            public IActionResult Users()
            {
                User user1 = new User()
                {
                    FirstName = "Moose",
                    LastName = "Phillips"
                };
                User user2 = new User()
                {
                    FirstName = "Sarah"
                };
                User user3 = new User()
                {
                    FirstName = "Jerry"
                };
                User user4 = new User()
                {
                    FirstName = "Rene",
                    LastName = "Ricky"
                };
                User user5 = new User()
                {
                    FirstName = "Barbarah"
                };

                List<User> viewModel = new List<User>()
                {
                    user1, user2, user3, user4, user5
                };
                return View(viewModel);
            }

            [HttpGet("/user")]
            public IActionResult MyUser()
            {
                User newUser = new User()
                {
                    FirstName = "Moose",
                    LastName = "Phillips"
                    
                };

                return View(newUser);
            }

        }


    }
