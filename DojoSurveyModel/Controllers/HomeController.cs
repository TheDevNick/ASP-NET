    using Microsoft.AspNetCore.Mvc;
    using FormSurvey.Models;
    namespace FormSurvey.Controllers     //be sure to use your own project's namespace!
    {
        public class HomeController : Controller   //remember inheritance??
        {

            [HttpGet("/")] //LocalHost: 5000
            public ViewResult Index()
            {
                return View("Index");
            }

            [HttpPost("survey")]
            public IActionResult Submission(Survey model)
            {
                // Handle your form submission here
                Survey newSurvey = new Survey()
                {
                    Name = model.Name, // Name is coming from the model class and getting set to the parameter model
                    Location = model.Location,
                    FavoriteLanguage = model.FavoriteLanguage,
                    Comment = model.Comment
                };
                return View(newSurvey);// passing the newSurvey object to the view to be able to use
            }



        }
    }
            