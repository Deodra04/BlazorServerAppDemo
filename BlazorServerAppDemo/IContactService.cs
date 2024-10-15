using BlazorServerAppDemo.Models;

namespace BlazorServerAppDemo
{
    public interface IContactService
    {
        List<Contact> GetContacts();
        void AddContact(Contact contact);
    }
}
