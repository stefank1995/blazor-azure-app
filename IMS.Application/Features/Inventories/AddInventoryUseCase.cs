using IMS.Application.Contracts.Persistence;
using IMS.Application.Features.Inventories.Interfaces;
using IMS.Domain.Entities;

namespace IMS.Application.Features.Inventories
{
	public class AddInventoryUseCase : IAddInventoryUseCase
	{
		private readonly IInventoryRepository inventoryRepository;

		public AddInventoryUseCase(IInventoryRepository inventoryRepository)
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
