using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProdCate.Models;

namespace ProdCate.Controllers
{
    public class ProdController : Controller
    {
        [HttpGet("products")]
        public IActionResult NewProd()
        {
            return View();
        }

        [HttpPost("itsaproduct")]
        public RedirectToActionResult AddProd()
        {
            return RedirectToAction("NewProd");
        }

        [HttpGet("products/{id}")]
        public IActionResult Prod()
        {
            return View();
        }

        [HttpGet("categories")]
        public IActionResult NewCate()
        {
            return View();
        }

        [HttpPost("itsacategory")]
        public RedirectToActionResult AddCate()
        {
            return RedirectToAction("NewCate");
        }

        [HttpGet("")]
        public IActionResult Cate()
        {
            return View();
        }
    }
}