using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegister.Models
{
    public class LoginUser
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please provide your email address.")]
        public string email {get; set;}
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please provide your password.")]
        public string pw {get; set;}
    }
}