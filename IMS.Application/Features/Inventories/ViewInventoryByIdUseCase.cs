using IMS.Application.Contracts.Persistence;
using IMS.Application.Features.Inventories.Interfaces;
using IMS.Domain.Entities;

namespace IMS.Application.Features.Inventories
{
	public class ViewInventoryByIdUseCase : IViewInventoryByIdUseCase
	{
		private readonly IInventoryRepository inventoryRepository;

		public ViewInventoryByIdUseCase(IInventoryRepository inventoryRepository)
		{
			this.inventoryRepository = inventoryRepository;
		}

		public async Task<Inventory> ExecuteAsync(int inventoryId)
		{
			return await inventoryRepository.GetInventoryByIdAsync(inventoryId);
		}
	}
}
