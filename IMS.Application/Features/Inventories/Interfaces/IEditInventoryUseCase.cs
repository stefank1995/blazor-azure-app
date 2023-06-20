using IMS.Domain.Entities;

namespace IMS.Application.Features.Inventories.Interfaces
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}