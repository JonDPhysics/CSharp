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
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetString("id") == null)
            {
                return RedirectToAction("Register");
            }
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
        [HttpPost("me")]
        public IActionResult PassFailLog(LoginUser user)
        {
            if (ModelState.IsValid)
            {
                User userInDb = DbContext.Users.FirstOrDefault(u => u.email == user.email);

                if(userInDb == null)
                {
                    ModelState.AddModelError("email", "Invalid Email/Password");
                    return View("Login");
                }

                PasswordHasher<LoginUser> hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(user, userInDb.pw, user.pw);
                if(result == PasswordVerificationResult.Failed)
                {
                    ModelState.AddModelError("pw", "Incorrect Password.");
                    return View("Login");
                }

                HttpContext.Session.SetInt32("id", userInDb.id);
                return RedirectToAction("Dashboard");
            }
            return RedirectToAction("Login");
        }
        [HttpGet("logout")]
        public RedirectToActionResult Clear()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}