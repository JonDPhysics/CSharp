using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using LoginRegister.Models;

namespace LoginRegister.Controllers
{
    public class LogRegController : Controller
    {
        private UserContext DbContext;
        public LogRegController(UserContext context)
        {
            DbContext = context;
        }

        [HttpGet("")]
        public ViewResult Register()
        {
            return View();
        }
        [HttpGet("login")]
        public ViewResult Login()
        {
            return View();
        }
        [HttpGet("success")]
        public ViewResult Dashboard()
        {
            return View();
        }
        [HttpPost("register")]
        public IActionResult PassFailReg(User user)
        {
            if (ModelState.IsValid)
            {
                if (DbContext.Users.Any(u => u.email == user.email))
                {
                    ModelState.AddModelError("Email", "Email already in use!");
                    return RedirectToAction("Register");
                }

                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.pw = Hasher.HashPassword(user, user.pw);

                DbContext.Add(user);
                DbContext.SaveChanges();
                return RedirectToAction("Login");
            }
            return RedirectToAction("Register");
        }
        [HttpPost("me/{userId}")]
        public IActionResult PassFailLog(LoginUser user, int id)
        {
            if (ModelState.IsValid)
            {
                var userInDb = DbContext.Users.FirstOrDefault(u => u.email == user.email);

                if(userInDb == null)
                {
                    ModelState.AddModelError("email", "Invalid Email/Password");
                    return View("Login");
                }
                return RedirectToAction("Dashboard", id);

                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, userInDb.pw, user.pw);
                if(result == 0)
                {
                    ModelState.AddModelError("pw", "Incorrect Password.");
                    return View("Login");
                }
                return RedirectToAction("Dashboard");
            }
            return RedirectToAction("Login");
        }
    }
}