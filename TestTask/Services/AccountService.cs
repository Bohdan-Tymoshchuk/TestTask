using TestTask.Abstractions;
using TestTask.Dtos;
using TestTask.Models;

namespace TestTask.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        public async Task<int> Create(AccountDto accountDto)
        {
            var account = new Account
            {
                Name = accountDto.Name,
                IncidentId = accountDto.IncidentId
            };

            var createdAccount =  await _accountRepository.CreateAsync(account);

            if (createdAccount == null)
            {
                throw new InvalidOperationException();
            }

            return createdAccount.Id;
        }
    }
}
