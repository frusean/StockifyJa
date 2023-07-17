using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StockifyJa
{
    public class CartItemWrapper
    {
        public string DisplayText { get; set; }
        public int CartItemId { get; set; }

        public override string ToString()
        {
            return DisplayText;
        }
    }
}
