using Microsoft.AspNetCore.Mvc;
using Validation.Models;
namespace Validation.Controllers
{
    public class ValidationController : Controller
    { 
        // In HomeController
        [HttpPost("user/create")]
            public IActionResult Create(User user)
            {
                if(ModelState.IsValid)
                {
                    // do somethng!  maybe insert into db?  then we will redirect
                    return RedirectToAction("Success");
                }
                else
                {
                    // Oh no!  We need to return a ViewResponse to preserve the ModelState, and the errors it now contains!
                    return View("NewUser");
                }
            }

        [HttpGet("/success")]
        public ViewResult Success()
        {
            return View("Success");
        }

        [HttpGet("/user")]
        public ViewResult NewUser()
        {
            return View("NewUser");
        }


        [HttpGet("/")]
            public ViewResult Index()
            {
                return View("index");
            }
    }
}
