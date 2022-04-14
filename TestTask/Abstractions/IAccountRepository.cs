using TestTask.Models;

namespace TestTask.Abstractions
{
    public interface IAccountRepository : IBaseRepository<Account>
    {
        public Task<Account> GetByNameAsync(string name);
    }
}
