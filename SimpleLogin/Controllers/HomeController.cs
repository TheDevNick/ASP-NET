    using System;
    using Microsoft.AspNetCore.Mvc;
    using SimpleLogin.Models;

namespace SimpleLogin.Controllers
{
    public class HomeController : Controller 
    {
        [HttpGet("")]
        public ViewResult Index()
        {
                return View();
        }

        [HttpPost("register")]
        public IActionResult RegisterUser(UserRegister user)
        {
            
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
                return View("Index");
        }

        [HttpPost("login")]
        public IActionResult LoginUser(UserLogin user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
                return View("Index");
        }

        [HttpGet("success")]
        public ViewResult success()
        {
            return View();
        }
    }
}