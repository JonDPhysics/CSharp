using System;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;
namespace ViewModelFun.Controllers
{
    public class FunController : Controller
    {
        [HttpGet("users")]
        public List<User> Users()
        {
            List<User> users = new List<User>
            
        }

}