using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LoginRegister.Models
{
    public class User
    {
        [Key]
        public int id {get; set;}
        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please provide your first name.")]
        [MinLength(2, ErrorMessage = "First Name must be at least 2 characters long.")]
        public string fname {get; set;}
        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please provide your last name.")]
        [MinLength(2, ErrorMessage = "Last Name must be at least 2 characters long.")]
        public string lname {get; set;}
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please provide your email.")]
        [DataType(DataType.EmailAddress)]
        
        public string email {get; set;}
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please provide a password.")]
        [MinLength(8, ErrorMessage = "Last Name must be at least 8 characters long.")]
        [DataType(DataType.Password)]
        public string pw {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;

        [NotMapped]
        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage =  "Please provide a confirm password.")]
        [Compare("pw", ErrorMessage = "Your Password doesn't match.")]
        [DataType(DataType.Password)]
        public string cpw {get; set;}
    }
}