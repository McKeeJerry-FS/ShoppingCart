namespace ShoppingCart.Models
{
	public class Product
	{
        public int ProductId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Price { get; set; }
        public string Image { get; set; } = string.Empty;
    }
}
