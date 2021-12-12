using System;
using System.ComponentModel.DataAnnotations;

namespace LoginRegister.Models
{
    public class LoginUser
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please provide your email address.")]
        [DataType(DataType.EmailAddress)]
        public string email {get; set;}
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please provide your password.")]
        [DataType(DataType.Password)]
        public string pw {get; set;}
    }
}