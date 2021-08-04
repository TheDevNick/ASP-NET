    using System;
    using Microsoft.AspNetCore.Mvc;
    using QuotingDojo.Models;
    using DbConnection;
    using System.Collections.Generic;

    namespace QuotingDojo
    {
        public class HomeController : Controller
        {
            [HttpGet("/")]
            public ViewResult Index()
            {
                return View();
            }

        [HttpGet("/quotes")]
        public IActionResult Quotes()
        {
            List<Dictionary<string, object>> AllQuotes = DbConnector.Query($"SELECT * FROM userquotes");
    
            ViewBag.Quotes = AllQuotes;
            return View();
        }

        [HttpPost("/create")]
        public IActionResult Create(GenerateQuote quote)
        {
            if(ModelState.IsValid)
            {
                string generatingQuote = $"INSERT INTO userquotes (name, quote) VALUES ('{quote.User}', '{quote.UserQuote}')";
                DbConnector.Execute(generatingQuote);
                return RedirectToAction("Quotes");
            }
            return View("Index");
        }

        
        }
    }