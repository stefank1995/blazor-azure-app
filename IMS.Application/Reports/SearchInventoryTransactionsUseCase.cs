using IMS.Application.Contracts.Persistence;
using IMS.Application.Reports.Interfaces;
using IMS.Domain.Entities;

namespace IMS.Application.Reports
{
    public class SearchInventoryTransactionsUseCase : ISearchInventoryTransactionsUseCase
    {
        private readonly IInventoryTransactionRepository inventoryTransactionRepository;

        public SearchInventoryTransactionsUseCase(IInventoryTransactionRepository inventoryTransactionRepository)
        {
            this.inventoryTransactionRepository = inventoryTransactionRepository;
        }

        public async Task<IEnumerable<InventoryTransaction>> ExecuteAsync(
                string inventoryName,
                DateTime? dateFrom,
                DateTime? dateTo,
                InventoryTransactionType? transactionType
            )
        {
            if (dateTo.HasValue) dateTo = dateTo.Value.AddDays(1);

            return await this.inventoryTransactionRepository.GetInventoryTransactionsAsync(
                    inventoryName,
                    dateFrom,
                    dateTo,
                    transactionType
                );
        }
    }
}
