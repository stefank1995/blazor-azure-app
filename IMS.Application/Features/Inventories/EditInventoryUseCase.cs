using IMS.Application.Contracts.Persistence;
using IMS.Application.Features.Inventories.Interfaces;
using IMS.Domain.Entities;

namespace IMS.Application.Features.Inventories
{
	public class EditInventoryUseCase : IEditInventoryUseCase
	{
		private readonly IInventoryRepository inventoryRepository;

		public EditInventoryUseCase(IInventoryRepository inventoryRepository)
		{
			this.inventoryRepository = inventoryRepository;
		}
		public async Task ExecuteAsync(Inventory inventory)
		{
			await this.inventoryRepository.UpdateInventoryAsync(inventory);
		}
	}
}
