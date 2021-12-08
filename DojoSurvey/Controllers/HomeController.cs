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
        public ViewResult Info(Survey fromForm)
        {
            // ViewBag.name = name;
            // ViewBag.location = location;
            // ViewBag.faveLang = faveLang;
            // ViewBag.comment = comment;
            return View(fromForm);
        }
    }
}