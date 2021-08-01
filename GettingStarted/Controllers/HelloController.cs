    using Microsoft.AspNetCore.Mvc;
    namespace GettingStarted.Controllers   //be sure to use your own project's namespace!
    {
        public class HelloController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet("")]
            public ViewResult HiThere()
            {
                return View();
            }
            [HttpGet("hello")]
            public RedirectToActionResult Hello()
            {
                return RedirectToAction("Index");
            }

            [HttpGet("users/{username}")]
            public string HelloUser(string username)
            {
                return $"hello {username}";
            }


        }
    }
