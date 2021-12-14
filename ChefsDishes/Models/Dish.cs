using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChefsDishes.Models
{
    public class Dish
    {
        [Key]
        public int id {get; set;}

        [Display(Name = "Name of Dish")]
        [Required(ErrorMessage = "Please provide a name for the dish.")]
        [MinLength(2, ErrorMessage = "Dish of dish must be at least 2 characters long.")]
        public string name {get; set;}

        [Display(Name = "Calories")]
        [Required]
        [Range(0, 3000, ErrorMessage = "Calories cannot be less than 0.")]
        public int? cal {get; set;}

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please provide a description for the dish.")]
        public string describe {get; set;}

        [Display(Name = "Tastiness")]
        [Required]
        public string taste {get; set;}

        public int chefId {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public Chef Creator {get; set;}
    }
}