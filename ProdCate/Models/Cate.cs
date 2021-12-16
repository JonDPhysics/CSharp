using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProdCate.Models
{
    public class Cate
    {
        [Key]
        public int Cateid {get; set;}
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please provide a category name.")]
        public string CateName {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public List<Asso> AssignedProd {get; set;}
        [NotMapped]
        public List<Cate> listOfCates {get; set;}
    }
}