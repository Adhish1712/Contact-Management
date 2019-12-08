using DomainModel.Contact;
using IBLL.IService;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ContactManagement.Controllers
{
    public class ContactController : ApiController
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        // GET: api/Contact
        [HttpGet]
        [Route("api/Contact/Contacts")]
        public IHttpActionResult Contacts()
        {
            return Ok<IEnumerable<Contact>>(_contactService.GetContacts().ToList());
        }

        // GET: api/GetContact/5
        [HttpGet]
        [Route("api/Contact/Contact/{id}")]
        public Contact Contact(int id)
        {
            return _contactService.GetContact(id);
        }

        // POST: api/CreateContact
        [HttpPost]
        [Route("api/Contact/AddContact")]
        public Contact Contact([FromBody]Contact contact)
        {
            return _contactService.CreateContact(contact);
        }

        // PUT: api/ChangeContactStatus/5
        [HttpPut]
        [Route("api/Contact/UpdateContact")]
        public bool UpdateContactStatus([FromBody]Contact contact)
        {
            return _contactService.ChangeContactStatus(contact);
        }


    }
}
