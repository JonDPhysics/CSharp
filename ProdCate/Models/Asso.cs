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
        public int CateId {get; set;}
        public Prod Product {get; set;}
        public Cate Category {get; set;}
    }
}