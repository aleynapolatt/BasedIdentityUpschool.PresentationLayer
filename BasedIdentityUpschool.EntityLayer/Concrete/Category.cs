using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasedIdentityUpschool.EntityLayer.Concrete
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        // ilişkinin türü ne olmalı ? -- 1 e çok 
        
        public List<Product> Products { get; set; }
    }
}
