using Microsoft.AspNetCore.Mvc;
using DojoSurvey.Models;
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
            // ViewBag.name = name;
            // ViewBag.location = location;
            // ViewBag.faveLang = faveLang;
            // ViewBag.comment = comment;
            Survey result = new Survey(name,location,faveLang,comment);
            return View(result);
        }
    }
}