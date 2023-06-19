using IMS.Domain.Entities;

namespace IMS.Application.Features.Inventories.Interfaces
{
	public interface IViewInventoriesByName
	{

		Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
	}
}