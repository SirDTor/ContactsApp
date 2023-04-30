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
        /// <param name="contact"></param>
        /// <returns></returns>
        public List<Contact> SortContactsBySurname(List<Contact> contact)
        {
            var orderByContact = contact.OrderBy(c => c.FullName).ToList();
            return orderByContact;
        }

        /// <summary>
        /// Возвращает список именинников
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public List<Contact> FindBirhdayContact(List<Contact> contact)
        {
            var birthdayContacts = contact.Where(c => c.DateOfBirth.Day == DateTime.Today.Day
            && c.DateOfBirth.Month == DateTime.Today.Month).ToList();
            return birthdayContacts;
        }

        /// <summary>
        /// Возвращает найденные по подстроке контакты
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Contact> FindContact(List<Contact> contact, string name)
        {
            var selectedContact = contact.Where(c => c.FullName.Contains(name)).ToList();
            return selectedContact;
        }
    }
}

