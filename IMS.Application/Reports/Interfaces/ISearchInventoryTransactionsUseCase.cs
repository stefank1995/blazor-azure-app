using IMS.Domain.Entities;

namespace IMS.Application.Reports.Interfaces
{
    public interface ISearchInventoryTransactionsUseCase
    {
        Task<IEnumerable<InventoryTransaction>> ExecuteAsync(string inventoryName, DateTime? dateFrom, DateTime? dateTo, InventoryTransactionType? transactionType);
    }
}