using TestTask.Abstractions;
using TestTask.Dtos;
using TestTask.Models;

namespace TestTask.Services
{
    public class ContactService : IContactService
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IContactRepository _contactService;

        public ContactService(IAccountRepository accountRepository, IContactRepository contactService)
        {
            _accountRepository = accountRepository;
            _contactService = contactService;
        }
        public async Task<int?> Create(ContactDto details)
        {
            var account = await _accountRepository.GetByNameAsync(details.AccountName);

            if (account is null) return null;

            var contact = await _contactService.GetByEmailAsync(details.Email);

            if (contact is not null)
            {
                contact.FirstName = details.FirstName;
                contact.LastName = details.LastName;
                contact.AccountId = contact.AccountId == null ? account.Id : contact.AccountId;

                await _contactService.UpdateAsync(contact);

                return contact.Id;
            }

            var newContact = new Contact
            {
                FirstName = details.FirstName,
                LastName = details.LastName,
                Email = details.Email,
                AccountId = account.Id
            };

            var createdContact = await _contactService.CreateAsync(newContact);

            return createdContact.Id;
        }
    }
}
