    using Microsoft.AspNetCore.Mvc;
    namespace Testing     //be sure to use your own project's namespace!
    {
        public class HelloController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet("")]       //type of request
            // LocalHost:5000/
            public IActionResult HiThere()
            {
                ViewBag.Example = "this is a example";
                return View();
            }
            // LocalHost:5000/hello
            [HttpGet("hello")]       //type of request

            public RedirectToActionResult Hello()
            {
                var param = new{username = "Nick", location = "Chicago"};
                return RedirectToAction("HelloUser", param);
            }

            // LocalHost:5000/users/???
            [HttpGet("users/{username}/{location}")]// 
            public string HelloUser(string username, string location)
            {
                if(location == "Chicago")
                    return $"Hello {username} from {location} go Bulls!";
                return $"Hello {username} from {location}!";
            }

        }
    }