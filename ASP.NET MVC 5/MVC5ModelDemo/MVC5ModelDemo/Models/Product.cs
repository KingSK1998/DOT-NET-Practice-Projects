namespace MVC5ModelDemo.Models
{
    public class Product
    {
        public int? ProductId { get; set; }
        public string? ProductName { get; set; }
        public int? OrderId { get; set; }
        public int? Quantity { get; set; }

        public Product() { }

        public Product(int productId, string? productName, int orderId, int quantity)
        {
            ProductId = productId;
            ProductName = productName;
            OrderId = orderId;
            Quantity = quantity;
        }

        public static Product GetProduct()
        {
            return new Product(01, "C# Book", 02, 2);
        }
    }
}
