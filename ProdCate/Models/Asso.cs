using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ProdCate.Models
{
    public class Asso
    {
        [Key]
        public int AssoId {get; set;}
        public int ProdId {get; set;}
        public Prod ProdWithCate {get; set;}
        public int Cateid {get; set;}
        public Cate CateWithProd {get; set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;
    }
}