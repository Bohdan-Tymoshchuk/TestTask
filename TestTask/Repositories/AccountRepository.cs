using Microsoft.EntityFrameworkCore;
using TestTask.Abstractions;
using TestTask.Data;
using TestTask.Models;

namespace TestTask.Repositories
{
    public class AccountRepository : BaseRepository<Account>, IAccountRepository
    {
        private readonly DataContext _context;

        public AccountRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Account> GetByNameAsync(string name)
        {
            return await _context.Accounts.FirstOrDefaultAsync(x => x.Name == name);
        }
    }
}
