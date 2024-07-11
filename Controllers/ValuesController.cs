using LearningApplication.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LearningApplication.Services;
using LearningApplication.Services.Interface;
using LearningApplication.Services.Implement;

namespace LearningApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IValueService _valueService;

        public ValuesController(IValueService valueService) 
        {
            _valueService = valueService;
        }


        [HttpGet("GetContacts")]
        public IEnumerable<Contact> GetContacts()
        {
            return _valueService.GetContacts();

        }

        [HttpGet("GetContactByName")]
        public Contact GetContactByName(Guid id) 
        {
            return _valueService.GetContactsByName(id);
        }

        [HttpPost("SaveContact")]
        public int SaveContact(Request request)
        {
          var response = _valueService.SaveContact(request);
            return response;
        }
    }
    
}
