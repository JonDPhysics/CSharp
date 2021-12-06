using System;
using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost("result")]
        public ViewResult Info(string name, string location, string faveLang, string comment)
        {
            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.faveLang = faveLang;
            ViewBag.comment = comment;
            return View();
        }
    }
}