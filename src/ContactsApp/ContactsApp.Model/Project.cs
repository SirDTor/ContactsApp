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
        public List<Contact> Contacts = new List<Contact>();

        /// <summary>
        /// Возвращает отсортированный список контактов
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public List<Contact> SortContactsBySurname(List<Contact> contact)
        {
            var selectedContact = from p in contact
                                  orderby p.FullName
                                  select p.FullName;
            return (List<Contact>)selectedContact;
        }

        /// <summary>
        /// Возвращает список именинников
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public List<Contact> FindBirhdayContact(List<Contact> contact)
        {
            var selectedContact = from p in contact
                                  where p.DateOfBirth == DateTime.Now
                                  select p;
            return (List<Contact>)selectedContact;
        }

        /// <summary>
        /// Возвращает найденные по подстроке контакты
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public List<Contact> FindContact(List<Contact> contact)
        {
            string contactToFind = "Зорин";
            var selectedContact = from p in contact
                                  where p.FullName == contactToFind
                                  select p;
            return (List<Contact>)selectedContact;
        }
    }
}

