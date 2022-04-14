using TestTask.Dtos;

namespace TestTask.Abstractions
{
    public interface IContactService
    {
        public Task<int?> Create(ContactDto details);
    }
}
