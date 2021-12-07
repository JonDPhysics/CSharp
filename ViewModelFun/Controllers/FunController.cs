using System;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;
namespace ViewModelFun.Controllers
{
    public class FunController : Controller
    {
        [HttpGet("")]
        public IActionResult Names()
        {
            string[] names = new string[]
            {
                "Sally",
                "Billy",
                "Joey",
                "Moose"
            };
            return View(names);
        }
    }
}