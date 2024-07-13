using LearningApplication.Model;
namespace LearningApplication.Services.Interface
{
    public interface IValueService
    {
        public IList<Contact> GetContacts();
        public IEnumerable<Contact> GetContactsByName(string name);
        public int SaveContact(Request request);
        public int UpdateContact(Request request);
    }
}
