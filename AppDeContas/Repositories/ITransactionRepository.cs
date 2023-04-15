using AppDeContas.Models;

namespace AppDeContas.Repositories
{
    public interface ITransactionRepository
    {
        void Add(Transaction transaction);
        void Delete(Transaction transaction);
        List<Transaction> GetAll();
        Transaction GetById(int id);
        void Update(Transaction transaction);
    }
}