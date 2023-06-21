using IMS.Domain.Entities;

namespace IMS.Application.Contracts.Persistence
{
	public interface IInventoryRepository
	{
		public Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name);

		public Task<Inventory> GetInventoryByIdAsync(int inventoryId);

		Task AddInventoryAsync(Inventory inventory);

		Task UpdateInventoryAsync(Inventory inventory);
	}
}
