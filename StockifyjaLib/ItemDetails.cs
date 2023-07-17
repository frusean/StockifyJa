namespace StockifyjaLib
{
    public class ItemDetails
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public int ProductID { get; set; }
        public int CartItemID { get; set; }

        public override string ToString()
        {
            return $"{ProductName} - Quantity: {Quantity} - Price: {Price:C}";
        }
    }
}
