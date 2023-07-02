using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockifyjaLib
{
    public class ItemDetails
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"{ProductName} - Quantity: {Quantity} - Price: {Price:C}";
        }
    }
}
