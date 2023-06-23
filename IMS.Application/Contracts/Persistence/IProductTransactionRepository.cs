using IMS.Domain.Entities;

namespace IMS.Application.Contracts.Persistence
{
    public interface IProductTransactionRepository
    {
        Task ProduceAsync(string productionNumber, Product product, int quantity, string doneBy);
        Task SellProductAsync(string salesOrderNumber, Product product, int quantity, double unitPrice, string doneBy);
        Task<IEnumerable<ProductTransaction>> GetProductTransactionsAsync(string productName, DateTime? dateFrom, DateTime? dateTo, ProductTransactionType? transactionType);
    }
}
