using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockifyjaLib
{
    public class OrderCalculator
    {
        public decimal GctRate { get; set; }

        public OrderCalculator(decimal gctRate)
        {
            GctRate = gctRate;
        }

        public decimal CalculateGCT(List<string> items)
        {
            decimal totalBeforeGCT = items.Sum(item =>
            {
                string[] parts = item.Split(',');
                if (parts.Length < 3)
                    return 0;

                decimal price, quantity;

                if (!decimal.TryParse(parts[2].Split(':')[1].Trim(), out price))
                {
                    Console.WriteLine($"Failed to parse price from: {parts[2].Split(':')[1].Trim()}");
                    return 0;
                }
                if (!decimal.TryParse(parts[1].Split(':')[1].Trim(), out quantity))
                {
                    Console.WriteLine($"Failed to parse quantity from: {parts[1].Split(':')[1].Trim()}");
                    return 0;
                }

                return price * quantity;
            });
            return totalBeforeGCT * GctRate;
        }

    }
}
