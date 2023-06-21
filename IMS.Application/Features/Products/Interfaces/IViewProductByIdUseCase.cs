using IMS.Domain.Entities;

namespace IMS.Application.Features.Products.Interfaces
{
    public interface IViewProductByIdUseCase
    {
        Task<Product?> ExecuteAsync(int productId);
    }
}