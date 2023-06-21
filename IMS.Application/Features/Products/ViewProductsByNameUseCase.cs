using IMS.Application.Contracts.Persistence;
using IMS.Application.Features.Products.Interfaces;
using IMS.Domain.Entities;

namespace IMS.Application.Products.Interfaces
{
    public class ViewProductsByNameUseCase : IViewProductsByNameUseCase
    {
        private readonly IProductRepository productRepository;
        public ViewProductsByNameUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ExecuteAsync(string name = "")
        {
            return await productRepository.GetProductsByNameAsync(name);
        }
    }
}