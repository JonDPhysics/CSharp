using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;


namespace RandomPasscode
{
    public class PassController : Controller
    {
        private readonly ILogger<PassController> _logger;

        public PassController(ILogger<PassController> logger)
        {
            _logger = logger;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            if(HttpContext.Session.GetInt32("Count") == null)
            {
            HttpContext.Session.SetInt32("Count", 1);
            }
            GenerateCode();
            int? count = HttpContext.Session.GetInt32("Count");

            ViewBag.Count = count;
            ViewBag.Code = TempData["anotherCode"];

            
            return View();
        }

        [HttpGet("moreCount")]
        public IActionResult OneMore()
        {
            int? count = HttpContext.Session.GetInt32("Count");
            count = count++;
            HttpContext.Session.SetInt32("Count", (int) count);
            
            return RedirectToAction("Index");
        }

        public void GenerateCode()
        {
            OneMore();

            string asEasyAsABC = "ABCDEFGHJKLMNOPQRSTUVWXYZ0123456789";
            char[] pc = asEasyAsABC.ToCharArray();
            Random code = new Random();
            char[] pass = new char[14];
            for(int c = 0; c < pass.Length; c++)
            {
                pass[c] = pc[code.Next(35)];
            }

            TempData["anotherCode"] = new string(pass);
        }
    }
}