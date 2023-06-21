using IMS.Domain.Entities;

namespace IMS.Application.Contracts.Persistence
{
	public interface IProductRepository
	{
		Task<IEnumerable<Product>> GetProductsByNameAsync(string name);
		Task AddProductAsync(Product product);
		Task<Product?> GetProductByIdAsync(int productId);
		Task UpdateProductAsync(Product product);
	}
}