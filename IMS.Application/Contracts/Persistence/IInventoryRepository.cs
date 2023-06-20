using IMS.Domain.Entities;

namespace IMS.Application.Contracts.Persistence
{
	public interface IInventoryRepository
	{
		public Task<IEnumerable<Inventory>> GetInventoryByNameAsync(string name);

		Task AddInventoryAsync(Inventory inventory);

		Task UpdateInventoryAsync(Inventory inventory);
	}
}
