using System;
using System.Collections.Generic;
using System.Text;

namespace AV_P.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime DateCreate { get; set; }
        public int Stock { get; set; }

        public List<ProductInCategory> ProductInCategories { get; set; }
        public List<ProductTranslation> ProductTranslations { get; set; }
    }
}
