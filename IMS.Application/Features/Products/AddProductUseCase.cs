using IMS.Application.Contracts.Persistence;
using IMS.Application.Features.Products.Interfaces;
using IMS.Domain.Entities;

namespace IMS.Application.Products.Interfaces
{
    public class AddProductUseCase : IAddProductUseCase
    {
        private readonly IProductRepository productRepository;

        public AddProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task ExecuteAsync(Product product)
        {
            if (product == null) return;

            await this.productRepository.AddProductAsync(product);
        }
    }
}