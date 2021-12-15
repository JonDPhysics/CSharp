using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ChefsDishes.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get; set;}

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please provide the Chef's first name.")]
        [MinLength(2, ErrorMessage = "Chef's first name must be at least 2 characters long.")]
        public string fname {get; set;}

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please provide the Chef's last name.")]
        [MinLength(2, ErrorMessage = "Chef's last name must be at least 2 characters long.")]
        public string lname {get; set;}

        [Display(Name = "Age")]
        [Required(ErrorMessage = "Please provide the Chef's age.")]
        public DateTime dob {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} =DateTime.Now;
        public List<Dish> CreatedDish {get; set;}
    }
}