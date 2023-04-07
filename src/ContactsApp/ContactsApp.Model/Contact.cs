﻿using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    internal class Contact: ICloneable
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
                if (_fullName.Length >= 100)
                {
                    throw new ArgumentException($"Contact name must be less than {_fullName.Length}");
                }
                _fullName = value;
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
                if (_email.Length >= 100)
                {
                    throw new ArgumentException($"Contact email must be less than {_email.Length}");
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
                string PhoneNumberValidationMask = @"^((\+7|7|8)[\(]?(\d{3})\)\d{3}-(\d{2}-\d{2}))$";
                if (!Regex.IsMatch(_phone, PhoneNumberValidationMask))
                {
                    throw new ArgumentException($"The phone number contains an invalid character.");
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
                if (_dateOfBirth.Year <= 1900 && _dateOfBirth.Year > 2023)
                {
                    throw new ArgumentException($"Year must be less or more than current year" + $"But was {_dateOfBirth.Year}");
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
                if (_idVk.Length >= 50)
                {
                    throw new ArgumentException($"Contact ID must be less than {_idVk.Length}");
                }
                _idVk = value;
            }
        }

        ///  <summary>
        /// Создает экземпляр <see cref="Contact">
        /// </summary>
        public Contact(string fullName, string email, string phone, DateTime dateOfBirth, string idVk)
        {
            FullName = fullName;
            Email = email;
            Phone = phone;
            DateOfBirth = dateOfBirth;
            IdVk = idVk;
        }

        /// <summary>
        /// Клонирует экзмепляр класса
        /// </summary>
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}