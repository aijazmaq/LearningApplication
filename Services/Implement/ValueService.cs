using LearningApplication.Services.Interface;
using LearningApplication.Model;

namespace LearningApplication.Services.Implement
{
    public class ValueService : IValueService
    {
        private DataContext _context;
        public ValueService(DataContext context)
        {
            _context = context;
        }

        public IList<Contact> GetContacts()
        {
            return _context.contacts.ToList();
        }

        public Contact GetContactsByName(Guid id) 
        {
            return _context.contacts.Find(id);
        }
        public int SaveContact(Request request)
        {
            var requestObj = new Contact();
            requestObj.Id = Guid.NewGuid();
            requestObj.Name = request.Name;
            requestObj.Phone = request.Phone;
            requestObj.Email = request.Email;
            requestObj.Address = request.Address;
            _context.contacts.Add(requestObj );
            return _context.SaveChanges();
        }
    }
}
