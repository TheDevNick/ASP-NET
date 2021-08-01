    using Microsoft.AspNetCore.Mvc;
    namespace Portfolio.Controllers     
    {
        public class MainController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet("/")]       //type of request
            public ViewResult Index()
            {
                return View("Index");
            }


        }
    }
