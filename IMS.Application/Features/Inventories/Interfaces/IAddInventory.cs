using IMS.Domain.Entities;

namespace IMS.Application.Features.Inventories.Interfaces
{
    public interface IAddInventory
    {
        Task ExecuteAsync(Inventory inventory);
    }
}