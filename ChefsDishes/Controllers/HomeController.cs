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
    public class HomeController : Controller
    {
        private TheContext _context;
        public HomeController(TheContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public ViewResult Chefs()
        {
            IndexView chefWithDishes = new IndexView()
            {
                AllDishes = _context.Dishes
                .Include(dish => dish.Creator)
                .ToList(),
                
                // AllChefs = _context.Chefs
                // .Include(chef => chef.CreatedDish)
                // .ToList()
            };
            return View(chefWithDishes);
        }

        [HttpGet("new")]
        public ViewResult NewChef()
        {
            return View();
        }

        [HttpPost("itsachef")]
        public RedirectToActionResult AddChef(Chef aChef)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aChef);
                _context.SaveChanges();
                return RedirectToAction("Chefs");
            }
            return RedirectToAction("NewChef", aChef);
        }

        [HttpGet("dishes")]
        public ViewResult Dishes()
        {
            List<Dish> dishesWithChef = _context.Dishes
            .Include(dish => dish.Creator)
            .ToList();
            return View(dishesWithChef);
        }

        [HttpGet("dishes/new")]
        public ViewResult NewDishes()
        {
            Dish newDish = new Dish()
            {
                Creators = _context.Chefs.ToList()
            };
            return View(newDish);
        }
        [HttpPost("itsadish")]
        public RedirectToActionResult AddDish(Dish aDish)
        {
            if (ModelState.IsValid)
            {
                _context.Add(aDish);
                _context.SaveChanges();
                return RedirectToAction("Dishes");
            }
            return RedirectToAction("NewDishes");
        }
    }
}