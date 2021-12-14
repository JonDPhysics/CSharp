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
            ViewBag.WomensLeagues = _context.Leagues.Where(l => l.Name.Contains("Women")).ToList();
            ViewBag.HockeyLeagues = _context.Leagues.Where(l => l.Name.Contains("Hockey")).ToList();
            ViewBag.NotFootballLeagues = _context.Leagues.Where(l => l.Name.Contains("Football")).ToList();
            ViewBag.Conferences = _context.Leagues.Where(l => l.Name.Contains("Conference")).ToList();
            ViewBag.AtlanticLeagues = _context.Leagues.Where(l => l.Name.Contains("Atlantic")).ToList();
            ViewBag.DallasTeams = _context.Teams.Where(t => t.Name.Contains("Dallas")).ToList();
            ViewBag.Raptors = _context.Teams.Where(t => t.Name.Contains("Raptors")).ToList();
            ViewBag.CityLocation = _context.Teams.Where(t => t.Name.Contains("City")).ToList();
            ViewBag.StartWithT = _context.Teams.Where(t => t.Name.Contains("T")).ToList();
            ViewBag.AllTeamsLocation = _context.Teams.OrderBy(t => t.Location).ToList();
            ViewBag.AllTeamsName = _context.Teams.OrderByDescending(t => t.TeamName).ToList();
            ViewBag.LNameCooper = _context.Players.Where(p => p.LastName.Contains("Cooper")).ToList();
            ViewBag.FNameJoshua = _context.Players.Where(p => p.FirstName.Contains("Joshua")).ToList();
            ViewBag.CooperNotJoshua = _context.Players.Where(p => p.LastName.Contains("Cooper") && !p.FirstName.Contains("Joshua")).ToList();
            ViewBag.AlexanderOrWyatt = _context.Players.Where(p => p.FirstName.Contains("Alexander") || p.FirstName.Contains("Wyatt")).ToList();
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