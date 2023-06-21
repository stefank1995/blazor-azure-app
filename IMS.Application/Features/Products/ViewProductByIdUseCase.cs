using IMS.Application.Contracts.Persistence;
using IMS.Application.Features.Products.Interfaces;
using IMS.Domain.Entities;

namespace IMS.Application.Products.Interfaces
{
    public class ViewProductByIdUseCase : IViewProductByIdUseCase
    {
        private readonly IProductRepository productRepository;

        public ViewProductByIdUseCase(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public async Task<Product?> ExecuteAsync(int productId)
        {
            return await this.productRepository.GetProductByIdAsync(productId);
        }
    }
}