using IMS.Domain.Entities;

namespace IMS.Application.Features.Inventories.Interfaces
{
	public interface IViewInventoryByIdUseCase
	{
		Task<Inventory> ExecuteAsync(int inventoryId);
	}
}