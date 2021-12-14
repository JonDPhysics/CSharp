using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ChefsDishes.Models;

namespace ChefsDishes.Controllers
{
    public class HomeController : Controler
    {
        [HttpGet("")]
        public ViewResult Chefs()
        {
            return View();
        }

        [HttpGet("new")]
        public ViewResult NewChef()
        {
            return View();
        }

        [HttpGet("dishes")]
        public ViewResult Dishes()
        {
            return View();
        }

        [HttpGet("dishes/new")]
        public ViewResult NewDish()
        {
            return View();
        }
    }
}