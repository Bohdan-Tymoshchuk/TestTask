using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestTask.Abstractions;
using TestTask.Dtos;

namespace TestTask.Controllers
{
    [Route("api/accounts")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountsController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost]
        public Task<int> Create(AccountDto account)
        {
            return _accountService.Create(account);
        }
    }
}
