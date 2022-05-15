using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class ProductDto : BaseDto
    {
        public string Name { get; set; }
        public int UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }

        public int CategoryId { get; set; }
    }
}
