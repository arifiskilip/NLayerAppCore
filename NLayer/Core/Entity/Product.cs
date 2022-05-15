using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entity
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ProductFeature ProductFeature { get; set; }
    }
}
