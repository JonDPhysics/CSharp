using System.Collections.Generic;

namespace ProdCate.Models
{
    public class CateInfoView
    {
        public Cate ToRender { get; set; }
        public List<Prod> ToAdd { get; set; }
        public Asso AddProd {get; set;}
    }
}