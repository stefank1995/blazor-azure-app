using IMS.Application.Contracts.Persistence;
using IMS.Application.Features.Products.Interfaces;
using IMS.Domain.Entities;

namespace IMS.Application.Products.Interfaces
{

    public class EditProductUseCase : IEditProductUseCase
    {
        private readonly IProductRepository productRepository;

        public EditProductUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task ExecuteAsync(Product product)
        {
            await this.productRepository.UpdateProductAsync(product);
        }
    }
}