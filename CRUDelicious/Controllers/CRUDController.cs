using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using CRUDelicious.Models;
using Microsoft.AspNetCore.Http;
using System.Linq;

namespace CRUDelicious.Controllers
{
    public class CRUDController : Controller
    {
        private DishContext DbContext;
        public CRUDController(DishContext context)
        {
            DbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            List<theDish> allDishes = DbContext.Dishes.ToList();
            return View(allDishes);
        }
        [HttpGet("new")]
        public ViewResult NewDish()
        {
            return View();
        }
        [HttpPost("create")]
        public IActionResult CreateDish(theDish data)
        {
            if (ModelState.IsValid)
            {
                DbContext.Add(data);
                DbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            return RedirectToAction("NewDish");
        }
        [HttpGet("{DishId}")]
        public ViewResult OneDish(int dishId)
        {
            theDish toRender = DbContext.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            return View(toRender);
        }
        [HttpGet("edit/{DishId}")]
        public ViewResult EditDish(int dishId)
        {
            theDish toRender = DbContext.Dishes.FirstOrDefault(dish => dish.DishId == dishId);
            return View(toRender);
        }
        [HttpPost("update/{DishId}")]
        public IActionResult UpdateDish(theDish data, int dishId)
        {
            theDish RetrievedDish = DbContext.Dishes
                .FirstOrDefault(dish => dish.DishId == dishId);
            RetrievedDish.Dish = data.Dish;
            RetrievedDish.Chef = data.Chef;
            RetrievedDish.Calories = data.Calories;
            RetrievedDish.Tastiness = data.Tastiness;
            RetrievedDish.Description = data.Description;
            RetrievedDish.UpdatedAt = DateTime.Now;

            DbContext.SaveChanges();

            return RedirectToAction("Index");
        }
        [HttpPost("delete/{DishId}")]
        public IActionResult DeleteDish(int dishId)
        {
            theDish RetrievedDish = DbContext.Dishes
                .SingleOrDefault(dish => dish.DishId == dishId);
            
            DbContext.Dishes.Remove(RetrievedDish);
            DbContext.SaveChanges();

            List<theDish> allDishes = DbContext.Dishes.ToList();
            return RedirectToAction("Index", allDishes);
        }
    }
}