using Microsoft.AspNetCore.Mvc;
namespace portfolio2.Controllers
{
    public class IndexController : Controller
    {
        [HttpGet("/")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpGet("projects")]
        public ViewResult projects()
        {
            return View();
        }
        [HttpGet("contact")]
        public ViewResult contact()
        {
            return View();
        }
        [HttpPost("home")]
        public RedirectToActionResult home()
        {
            return RedirectToAction("Index");
        }
    }
}