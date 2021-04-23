using System;
using System.Collections.Generic;
using System.Linq;
namespace Exam.Organizations
{
    public class OrganizationService
    {
        public List<IContactable> Contacts = new List<IContactable>();
        public OrganizationService(List<IContactable> contacts)
        {
            this.Contacts = contacts;
        }
        public bool AddContact(IContactable contact)
        {
            if (!Contacts.Contains(contact))
            {
                Contacts.Add(contact);
                return true;
            }
            return false;
        }
        public bool RemoveContact(IContactable contact)
        {
            try
            {
                Contacts.Remove(contact);
                return true;
            }
            catch
            {
                Console.WriteLine("Error happened on deleting contact: 31row OrganizationService.cs");
                return false;
            }
        }
        public bool EditContact(IContactable contact)
        {
            try
            {
                Contacts[Contacts.FindIndex(p => p.Id == contact.Id)] = contact;
                return true;
            }
            catch
            {
                Console.WriteLine("Error happened on editing contact: 44row OrganizationService.cs");
                return false;
            }
        }
        public IContactable GetContactByName(string Name)
        {
            return Contacts.Where(c => c.Name == Name).First();
        }
    }
}
