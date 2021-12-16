using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProdCate.Models
{
    public class Prod
    {
        [Key]
        public int ProdId {get; set;}
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please provide a product name.")]
        public string ProdName {get; set;}
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Please provide a product description.")]
        public string ProdDescribe {get; set;}
        [Display(Name = "Price")]
        [Required(ErrorMessage = "Please provide a product price.")]
        public float ProdPrice {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public List<Asso> Assigner {get; set;}
        public List<Cate> AllCats {get; set;}
    }
}