using DtMoney.Infra.Data.Contexto;
using DtMoney.Infra.Models;
using Microsoft.EntityFrameworkCore;

namespace DtMoney.Services.Trasactions
{
    public class TransactionService : ITransactionService
    {
        public readonly DtMoneyContext Db;
        private readonly DbSet<Transaction> Dbset;

        public TransactionService(DtMoneyContext context)
        {
            Db = context;
            Dbset = context.Set<Transaction>();
        }

        public async Task AddTransactions(Transaction transaction)
        {
            Dbset.Add(transaction);
            await SaveChanges();
        }

        public async Task<IEnumerable<Transaction>> GetTransactions()
        {
            return await Dbset.ToListAsync();
        }

        public virtual async Task RemoveTransactions(Guid id)
        {
            Dbset.Remove(new Transaction {  Id = id});
            await SaveChanges();
        }

        private async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
    }
}
