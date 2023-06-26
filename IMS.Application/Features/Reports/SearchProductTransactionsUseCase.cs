using IMS.Application.Contracts.Persistence;
using IMS.Application.Features.Reports.Interfaces;
using IMS.Domain.Entities;

namespace IMS.Application.Features.Reports
{
    public class SearchProductTransactionsUseCase : ISearchProductTransactionsUseCase
    {
        private readonly IProductTransactionRepository productTransactionRepository;

        public SearchProductTransactionsUseCase(IProductTransactionRepository productTransactionRepository)
        {
            this.productTransactionRepository = productTransactionRepository;
        }

        public async Task<IEnumerable<ProductTransaction>> ExecuteAsync(
                string productName,
                DateTime? dateFrom,
                DateTime? dateTo,
                ProductTransactionType? transactionType
            )
        {
            if (dateTo.HasValue) dateTo = dateTo.Value.AddDays(1);

            return await this.productTransactionRepository.GetProductTransactionsAsync(
                    productName,
                    dateFrom,
                    dateTo,
                    transactionType
                );
        }
    }
}
