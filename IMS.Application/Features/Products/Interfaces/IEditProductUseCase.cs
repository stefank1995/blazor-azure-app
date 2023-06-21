using IMS.Domain.Entities;

namespace IMS.Application.Features.Products.Interfaces
{
    public interface IEditProductUseCase
    {
        Task ExecuteAsync(Product product);
    }
}