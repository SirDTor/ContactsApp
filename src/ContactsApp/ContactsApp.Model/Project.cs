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
    internal class Project
    {
        /// <summary>
        ///  Возвращает или задает список контактов
        /// </summary>
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        /// <summary>
        /// Возвращает отсортированный список контактов
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public string SortContactsByFullName(Contact contact)
        {
            if (contact is null) throw new ArgumentException("Некорректное значение параметра");
            //return contact.FullName.CompareTo(contact.FullName);
            return contact.FullName;
        }

        /// <summary>
        /// Возвращает список именинников
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public string FindBirhdayContact(Contact contact) { return contact.FullName; }

        /// <summary>
        /// Возвращает найденные по подстроке контакты
        /// </summary>
        /// <param name="contact"></param>
        /// <returns></returns>
        public string FindContact(Contact contact) { return contact.FullName; }
    }
}

