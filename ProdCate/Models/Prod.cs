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
        public string ProdName {get; set;}
        public string ProdDescribe {get; set;}
        public float ProdPrice {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
        public List<Asso> Assigner {get; set;}
    }
}