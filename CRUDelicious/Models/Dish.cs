using System;
using System.ComponentModel.DataAnnotations;

namespace CRUDelicious.Models
{
    public class theDish
    {
        [Key]
        public int DishId {get; set;}
        [Display(Name = "Name of Dish")]
        [Required(ErrorMessage = "Please provide a name for your dish.")]
        [MinLength(2, ErrorMessage = "Your dishes name must be at least 2 characters long.")]
        public string Dish {get; set;}
        [Display(Name = "Chef's Name")]
        [Required(ErrorMessage = "Please provide a name for the chef.")]
        [MinLength(2, ErrorMessage = "The chef's name must be at least 2 caracters long.")]
        public string Chef {get; set;}
        [Display(Name = "# of Calories")]
        [Required(ErrorMessage = "Please provide the number of calories in your dish.")]
        [Range(0,3000, ErrorMessage = "Please enter a number from 0 to 3000.")]
        public string Calories {get; set;}
        [Display(Name = "Tastiness")]
        [Required]

        public string Tastiness {get; set;}
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please provide a description of your dish.")]
        [MinLength(10, ErrorMessage = "The description of your dish must be at least 20 charaters long.")]
        public string Description {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}