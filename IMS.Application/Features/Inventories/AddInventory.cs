using IMS.Application.Contracts.Persistence;
using IMS.Application.Features.Inventories.Interfaces;
using IMS.Domain.Entities;

namespace IMS.Application.Features.Inventories
{
	public class AddInventory : IAddInventory
	{
		private readonly IInventoryRepository inventoryRepository;

		public AddInventory(IInventoryRepository inventoryRepository)
		{
			this.inventoryRepository = inventoryRepository;
		}
		public async Task ExecuteAsync(Inventory inventory)
		{
			//if(!await this.inventoryRepository.ExistsAsync(inventory))
			await this.inventoryRepository.AddInventoryAsync(inventory);
		}
	}
}
