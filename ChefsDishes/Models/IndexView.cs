using System;
using ChefsDishes.Models;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace ChefsDishes.Models
{
    public class IndexView
    {
        public List<Chef> AllChefs {get; set;}
        public List<Dish> AllDishes {get; set;}
    }
}