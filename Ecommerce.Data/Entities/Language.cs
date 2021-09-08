using System.Collections;
using System.Collections.Generic;

namespace Ecommerce.Data.Entities
{
    public class Language
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        
        public virtual ICollection<ProductTranslation> ProductTranslations { get; set; }
        public virtual ICollection<CategoryTranslation> CategoryTranslations { get; set; }
    }
}