using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elettra
{
    public class Product:DBObject
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string Family { get; set; }
        public string Description { get; set; }

        bool Active { get; set; }

        public decimal BasePrice { get; set; }
        public List<decimal> VATRates { get; set; }

        public Product()
        {
            VATRates = new List<decimal>();
        }
    }
}
