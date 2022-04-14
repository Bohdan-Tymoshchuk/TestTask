using Microsoft.EntityFrameworkCore;
using TestTask.Abstractions;
using TestTask.Data;
using TestTask.Models;

namespace TestTask.Repositories
{
    public class ContactRepository : BaseRepository<Contact>, IContactRepository
    {
        public ContactRepository(DataContext context) : base(context)
        {
        }

        public async Task<Contact> GetByEmailAsync(string email)
        {
            return await _context.Contacts.FirstOrDefaultAsync(x => x.Email == email);
        }
    }
}
