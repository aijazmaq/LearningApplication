using LearningApplication.Model;
namespace LearningApplication.Services.Interface
{
    public interface IValueService
    {
        public IList<Contact> GetContacts();

        public Contact GetContactsByName(Guid id);
        public int SaveContact(Request request);
    }
}
