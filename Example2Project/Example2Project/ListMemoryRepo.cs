using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2Project
{
    public class ListMemoryRepo : IRepo
    {
        private List<Contact> contacts = new List<Contact>();

        public void Create(Contact contact)
        {
            contacts.Add(contact);
        }

        public void DeleteByEmail(string email)
        {
            foreach (var contact in contacts)
            {
                if (contact.Email == email)
                {
                    contacts.Remove(contact);
                    return;
                }
            }
        }

        public List<Contact> ReadAll()
        {
            return contacts;
        }

        public Contact ReadByEmail(string email)
        {
            foreach (var contact in contacts)
            {
                if (contact.Email == email)
                {
                    return (Contact)contact;
                }
            }
            return null;


        }

        public void Update(string email, Contact contact)
        {
            return;
        }
    }
}
