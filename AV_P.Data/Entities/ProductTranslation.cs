using System;
using System.Collections.Generic;
using System.Text;

namespace AV_P.Data.Entities
{
    public class ProductTranslation
    {
        public int Id { get; set; }
        public string LanguageId { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }

        public Product Product { get; set; }
        public Language Language { get; set; }
    }
}
