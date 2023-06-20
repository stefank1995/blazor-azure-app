using IMS.Domain.Entities;

namespace IMS.Application.Features.Inventories.Interfaces
{
	public interface IViewInventoriesByNameUseCase
	{

		Task<IEnumerable<Inventory>> ExecuteAsync(string name = "");
	}
}