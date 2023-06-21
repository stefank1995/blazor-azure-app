using IMS.CoreBusiness;

namespace IMS.Application.Features.Products.Interfaces
{
    public interface IViewProductByIdUseCase
    {
        Task<Product?> ExecuteAsync(int productId);
    }
}