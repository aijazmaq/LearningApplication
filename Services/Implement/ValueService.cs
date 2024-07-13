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

        public IEnumerable<Contact> GetContactsByName(string name) 
        {
            return _context.contacts.Where(cont=> cont.Name == name);
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

        public int UpdateContact(Request request)
        {
            var requestObj = new Contact();
            requestObj.Id = request.Id;
            requestObj.Name = request.Name;
            requestObj.Phone = request.Phone;
            requestObj.Email = request.Email;
            requestObj.Address = request.Address;
            _context.contacts.Update(requestObj);
            return _context.SaveChanges();
        }

    }
}
