using AV_P.Data.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace AV_P.Data.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public bool IsShowOnHome { set; get; }
        public int? ParentId { set; get; }
        public List<ProductInCategory> ProductInCategories { get; set; }

        public List<CategoryTranslation> CategoryTranslations { get; set; }
    }
}
