using DtMoney.Infra.Models;

namespace DtMoney.Services.Trasactions
{
    public interface ITransactionService
    {
        Task<IEnumerable<Transaction>> GetTransactions();
        Task AddTransactions(Transaction transaction);
        Task RemoveTransactions(Guid id);
    }
}
