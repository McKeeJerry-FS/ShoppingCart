using ShoppingCart.Models;

namespace ShoppingCart.Services.Interfaces
{
	public interface ICartService
	{
		IList<Product> Cart {  get; }
		int Total { get; }

		event Action OnChange;

		void AddProduct(Product product);
		void RemoveProduct(Product product);
	}
}
