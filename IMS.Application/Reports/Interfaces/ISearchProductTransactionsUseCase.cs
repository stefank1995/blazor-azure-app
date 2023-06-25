using IMS.Domain.Entities;

namespace IMS.Application.Reports.Interfaces
{
    public interface ISearchProductTransactionsUseCase
    {
        Task<IEnumerable<ProductTransaction>> ExecuteAsync(string productName, DateTime? dateFrom, DateTime? dateTo, ProductTransactionType? transactionType);
    }
}