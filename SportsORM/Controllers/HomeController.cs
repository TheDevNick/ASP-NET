using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            // getting all women leagues
            // WomensLeague is just a variable for the ViewBag to use(couldve named it anything)
            // _context calls the table u want to use (leagues in this example)
            //league is just a variable for the lambda expression to use(couldve named it anything)
            ViewBag.WomensLeague = _context.Leagues
                .Where(league => league.Name.Contains("Women"));

            ViewBag.HockeyLeague = _context.Leagues
                .Where(league => league.Sport.Contains("Hockey"));

            ViewBag.NonFootballLeague = _context.Leagues
                .Where(league => league.Sport != "Football");

            ViewBag.ConferenceLeagues = _context.Leagues
                .Where(league => league.Name.Contains("Conference"));

            ViewBag.AtlanticLeagues = _context.Leagues
                .Where(league => league.Name.Contains("Atlantic"));

            ViewBag.DallasTeams = _context.Teams
                .Where(team => team.Location == "Dallas");

            ViewBag.TeamRaptors = _context.Teams
                .Where(team =>team.TeamName == "Raptors");

            ViewBag.HaveCityInName = _context.Teams
                .Where(team => team.Location.Contains("City"));
            
            ViewBag.StartWithT = _context.Teams
                .Where(team => team.TeamName.StartsWith("T"));

            ViewBag.AlphaLocation = _context.Teams
                .OrderBy(team => team.Location);

            ViewBag.ReverseOrder = _context.Teams
                .OrderByDescending(team => team.TeamName);

            ViewBag.CooperPlayers = _context.Players
                .Where(player => player.LastName == "Cooper");

            ViewBag.JoshuaPlayers = _context.Players
                .Where(player => player.FirstName == "Joshua");

            ViewBag.CooperNotJoshua = _context.Players
                .Where(player => player.LastName == "Cooper" && player.FirstName != "Joshua");

            ViewBag.AlexanderOrWyatt = _context.Players
                .Where(player => player.FirstName == "Alexander" || player.FirstName == "Wyatt");

            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}