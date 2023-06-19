using IMS.Application.Contracts.Persistence;
using IMS.Application.Features.Inventories.Interfaces;
using IMS.Domain.Entities;

namespace IMS.Application.Features.Inventories
{
	public class ViewInventoriesByName : IViewInventoriesByName
	{
		public IInventoryRepository inventoryRepository { get; set; }
		public ViewInventoriesByName(IInventoryRepository inventoryRepository)
		{
			this.inventoryRepository = inventoryRepository;
		}
		public async Task<IEnumerable<Inventory>> ExecuteAsync(string name = "")
		{
			return await inventoryRepository.GetInventoryByNameAsync(name);


		}
	}
}
