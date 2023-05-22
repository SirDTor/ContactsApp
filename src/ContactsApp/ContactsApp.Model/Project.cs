using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает список контактов
    /// </summary>
    public class Project
    {
        /// <summary>
        /// Возвращает или задает список контактов
        /// </summary>
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        /// <summary>
        /// Возвращает отсортированный список контактов
        /// </summary>
        /// <param name="contacts"></param>
        /// <returns></returns>
        public List<Contact> SortContactsByFullName(List<Contact> contacts)
        {
            var orderByContact = contacts.OrderBy(contact => contact.FullName).ToList();
            return orderByContact;
        }

        /// <summary>
        /// Возвращает список именинников
        /// </summary>
        /// <param name="contacts"></param>
        /// <returns></returns>
        public List<Contact> FindBirthdayContacts(List<Contact> contacts)
        {
            var birthdayContacts = contacts.Where(contact => contact.DateOfBirth.Day == DateTime.Today.Day
            && contact.DateOfBirth.Month == DateTime.Today.Month).ToList();
            return birthdayContacts;
        }

        /// <summary>
        /// Возвращает найденные по подстроке контакты
        /// </summary>
        /// <param name="contacts"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Contact> FindContacts(List<Contact> contacts, string contactName)
        {
            if (contactName != "")
            {
                var selectedContact = contacts.Where(contact => contact.FullName.Contains(contactName)).ToList();
                return selectedContact;
            }
            else return contacts;
        }
    }
}

