using TestTask.Dtos;

namespace TestTask.Abstractions
{
    public interface IAccountService
    {
        public Task<int> Create(AccountDto account);
    }
}
