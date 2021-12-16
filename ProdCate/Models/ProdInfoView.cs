using System.Collections.Generic;

namespace ProdCate.Models
{
    public class ProdInfoView
    {
        public Prod ToRender { get; set; }
        public List<Cate> ToAdd { get; set; }

        public Asso AddCate {get; set;}
    }
}