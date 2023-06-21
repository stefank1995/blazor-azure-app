using IMS.CoreBusiness;

namespace IMS.Application.Features.Products.Interfaces
{
    public interface IEditProductUseCase
    {
        Task ExecuteAsync(Product product);
    }
}