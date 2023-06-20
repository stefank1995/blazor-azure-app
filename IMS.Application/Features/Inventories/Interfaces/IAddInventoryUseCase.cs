using IMS.Domain.Entities;

namespace IMS.Application.Features.Inventories.Interfaces
{
    public interface IAddInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}