using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockifyjaLib
{
    public static class AppState
    {
        public static List<ItemDetails> CartItems { get; set; } = new List<ItemDetails>();

        public static int CurrentUserID { get; set; }
    }

}
