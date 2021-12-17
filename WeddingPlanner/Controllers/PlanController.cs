using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WeddingPlanner.Models;

namespace WeddingPlanner.Controllers
{
    public class PlanController : Controller
    {
        private theContext _context;
        public PlanController(theContext context)
        {
            _context = context;
        }
        [HtppGet("")]
        public ViewResult LogReg()
        {
            return View();
        }
        [HtppPost("Dashboard")]
        public ViewResult Dashboard()
        {
            return View();
        }
        [HtppPost("wedding/plan")]
        public IActionResult OurPlan()
        {
            return View();
        }
        [HtppGet("new/plan")]
        public ViewResult WhatPlan()
        {
            return View();
        }
    }
}