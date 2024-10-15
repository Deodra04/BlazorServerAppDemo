using BlazorServerAppDemo.Models;
using BlazorServerAppDemo.Pages.ContactComponents;
using Microsoft.AspNetCore.Components;

namespace BlazorServerAppDemo.Pages
{
    public partial class Index
    {
        [Inject]
        IContactService contactService { get; set; }
        [Inject]
        NavigationManager navigationManager { get; set; }
        private List<Contact> contacts;

        private ContactList contactList;
        private bool isContactDisplayed = true;

        private Dictionary<string, object> MyTextboxAttributes = new Dictionary<string, object>
    {
        {"Maxlength","10"},
        {"placeholder","First Name"},
        {"type","text"}
    };

        protected async override Task OnInitializedAsync()
        {

            await Task.Delay(5000);
            //contacts = contactService.GetContacts();
            //contacts = new List<Contact>();
            contacts = new List<Contact>
            {
            new Contact
            {
                FirstName = "John",
                LastName = "Thomas",
                Email = "john@mail.com"
            },
            new Contact
            {
                FirstName = "Peter",
                LastName = "Bob",
                Email = "peter@mail.com"
            },
            new Contact
            {
                FirstName = "George",
                LastName = "David",
                Email = "george@mail.com"
            }
        };

            base.OnInitializedAsync();
        }     

        private void DeleteContact(Contact contact)
        {
            contacts.Remove(contact);
        }

        private void HideContacts()
        {
            isContactDisplayed = !isContactDisplayed;
            if (isContactDisplayed)
            {
                contactList.HideContacts();
            }
            else
            {
                contactList.ShowContacts();
            }
        }

        private void NavigateToTest()
        {
            navigationManager.NavigateTo("./testpage");
        }
    }
}
