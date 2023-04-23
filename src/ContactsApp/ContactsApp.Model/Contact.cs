using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ContactsApp.Model
{
    /// <summary>
    /// Описывает контакт
    /// </summary>
    public class Contact: ICloneable
    {
        /// <summary>
        /// Полное имя контакта
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Email контакта
        /// </summary>
        private string _email;

        /// <summary>
        /// Номер телефона контакта
        /// </summary>
        private string _phone;

        /// <summary>
        /// Дата рождения контакта
        /// </summary>
        private DateTime _dateOfBirth;

        /// <summary>
        /// ID ВКонтакте контакта
        /// </summary>
        private string _idVk;

        /// <summary>
        /// 
        /// </summary>
        private const string PhoneNumberValidationMask =
                    @"^((\+7|7|8)[[\(]?(\d{3})[\)]?]?\d{3}[[-]?(\d{2}[-]?]?\d{2}))$";

        /// <summary>
        /// Возвращает или задает полное имя контакта
        /// </summary>
        public string FullName  //Ограничение в 100 символов
        {
            get
            {
                return _fullName;
            }
            set
            {
                if (value.Length >= 100)
                {
                    throw new ArgumentException($"Contact name must be less than 100, value = {_fullName.Length}");
                }
                TextInfo toUpperTextInfo = CultureInfo.CurrentCulture.TextInfo;
                _fullName = toUpperTextInfo.ToTitleCase(value).ToString();
            }
        }

        /// <summary>
        /// Возвращает или задает email контакта
        /// </summary>
        public string Email    //Ограничение в 100 символов
        {
            get
            {
                return _email;
            }
            set
            {
                if (value.Length >= 100)
                {
                    throw new ArgumentException($"Contact email must be less than 100, value = {_email.Length}");
                }
                _email = value;
            }
        }

        /// <summary>
        /// Возвращает или задает номер телефона контакта
        /// </summary>
        public string Phone
        {
            get
            {
                return _phone;
            }
            set
            {
                if (!Regex.IsMatch(value, PhoneNumberValidationMask))
                {
                    throw new ArgumentException($"The phone number contains an invalid character.\n Example:\n " +
                        $"8(923)442-79-25\n" +
                        $"89234427925");
                }
                _phone = value;
            }
        }

        /// /// <summary>
        /// Возвращает или задает дату рождения контакта
        /// </summary>
        public DateTime DateOfBirth
        {
            get
            {
                return _dateOfBirth;
            }
            set
            {
                if (value.Year <= 1900 || value > DateTime.Now)
                {
                    throw new ArgumentException($"Year must be less or more than current year " + 
                        $"But was {value.Year}");
                }
                _dateOfBirth = value;
                
            }
        }

        ///  <summary>
        /// Возвращает или задает ID ВКонтакте контакта
        /// </summary>
        public string IdVk
        {
            get
            {
                return _idVk;
            }
            set
            {
                if (value.Length >= 50)
                {
                    throw new ArgumentException($"Contact ID must be less than 50, value = {_idVk.Length}");
                }
                _idVk = value;
            }
        }

        /// <summary>
        /// Создает экземпляр <see cref="Contact">
        /// </summary>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="dateOfBirth"></param>
        /// <param name="idVk"></param>
        public Contact(string fullName, string email, string phone, DateTime dateOfBirth, string idVk)
        {
            FullName = fullName;
            Email = email;
            Phone = phone;
            DateOfBirth = dateOfBirth;
            IdVk = idVk;
        }

        /// <summary>
        /// Создает пустой экземпляр <see cref="Contact"/>
        /// </summary>
        public Contact() { }

        /// <summary>
        /// Клонирует экзмепляр класса
        /// </summary>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
