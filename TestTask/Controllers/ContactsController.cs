using Microsoft.AspNetCore.Mvc;
using TestTask.Abstractions;
using TestTask.Dtos;

namespace TestTask.Controllers
{
    [Route("api/contacts")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;

        public ContactsController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ContactDto contact)
        {
            var contactId = await _contactService.Create(contact);

            if (contactId == null)
            {
                return new NotFoundObjectResult($"Account with such name '{contact.AccountName}' doesn`t exist");
            }

            return Ok(contactId);
        }
    }
}
