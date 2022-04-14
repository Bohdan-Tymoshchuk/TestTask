using TestTask.Models;

namespace TestTask.Abstractions
{
    public interface IContactRepository : IBaseRepository<Contact>
    {
        public Task<Contact> GetByEmailAsync(string email);
    }
}
