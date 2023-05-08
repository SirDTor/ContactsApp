﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactsApp.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RandomContacts
    {
        /// <summary>
        /// Поле класса <see cref="Project">
        /// </summary>
        private static Project _project = new Project();

        /// <summary>
        /// Переменная для генерации случайного числа
        /// </summary>
        private static Random _randomNumber = new Random();

        /// <summary>
        /// Поле фамилий
        /// </summary>
        private static string[] _arrSurname = {"Смирнов","Долгов","Беспалов",
            "Малышев","Толкачев", "Лазарев","Яковлев","Демин","Журавлев","Кондрашов" };

        /// <summary>
        /// Поле мужских имен
        /// </summary>
        private static string[] _arrMaleName = { "Тимур", "Михаил", "Иван", "Дмитрий",
            "Николай", "Тимофей" };

        /// <summary>
        /// Поле женских имен
        /// </summary>
        private static string[] _arrFemaleName = { "Амбразура", "София", "Анна",
            "Полина", "Елизавета", "Александра", "Анна" };

        /// <summary>
        /// Поле отчеств
        /// </summary>
        private static string[] _arrPatronymic = {"Амбразуров","Матвеев","Михайлов","Егоров",
            "Алексеев","Григорьев","Александров","Глебов", "Даниилов" };

        /// <summary>
        /// Поле ФИО
        /// </summary>
        private static string[] _fullName = new string[20];

        /// <summary>
        /// Поле Email
        /// </summary>
        private static string[] _email = { "o@outlook.com","hr6zdl@yandex.ru",
            "kaft93x@outlook.com","dcu@yandex.ru","19dn@outlook.com","pa5h@mail.ru",
            "281av0@gmail.com","8edmfh@outlook.com","sfn13i@mail.ru","g0orc3x1@outlook.com",
            "rv7bp@gmail.com","93@outlook.com", "er@gmail.com","o0my@gmail.com",
            "715qy08@gmail.com","vubx0t@mail.ru", "wnhborq@outlook.com","gq@yandex.ru",
            "ic0pu@outlook.com","o7khr@yandex.ru"};

        /// <summary>
        /// Поле номеров телефонов
        /// </summary>
        private static string[] _phone = { "8(923)480-65-83","8(923)234-84-20","8(923)136-38-75",
            "8(923)653-03-02","8(923)824-41-77","8(923)112-54-20","8(923)678-54-33",
            "8(923)971-37-41", "8(923)760-83-72","8(923)950-38-18"};

        /// <summary>
        /// Поле idVK
        /// </summary>
        private static string[] _idVk = { "id8626810", "id2307938", "id7027388", "id6938923",
            "id2570718", "id7381412", "id1153817", "id7013733", "id8111215", "id6492395" };


        /// <summary>
        /// Метод генерации случайного числа
        /// </summary>
        /// <param name="_randomNumber"></param>
        /// <param name="lengthOfArray"></param>
        /// <returns></returns>
        private static int GenerateDigit(int lengthOfArray)
        {
            return _randomNumber.Next(lengthOfArray);
        }

        /// <summary>
        /// Метод генерации случаного контакта
        /// </summary>
        /// <param name="_randomNumber"></param>
        /// <param name="randomContacts"></param>
        /// <returns></returns>
        public static Project GenerateRandomContactsName()
        {

            for (int i = 0; i <= 10; i++)
            {
                _fullName[i] = _arrSurname[GenerateDigit(_arrSurname.Length)] + " " +
                    _arrMaleName[GenerateDigit(_arrMaleName.Length)] + " "
                    + _arrPatronymic[GenerateDigit(_arrPatronymic.Length)] + "ич";

            }
            for (int i = 11; i < 20; i++)
            {
                _fullName[i] = _arrSurname[GenerateDigit(_arrSurname.Length)] + "а " +
                    _arrFemaleName[GenerateDigit(_arrFemaleName.Length)] + " "
                    + _arrPatronymic[GenerateDigit(_arrPatronymic.Length)] + "на";

            }
            for (int i = 0; i < 20; i++)
            {
                Contact contact = new Contact(_fullName[GenerateDigit(_fullName.Length)],
                _email[GenerateDigit(_email.Length)],
                    _phone[GenerateDigit(_phone.Length)], DateTime.Today,
                    _idVk[GenerateDigit(_idVk.Length)]);

                _project.Contacts.Add(contact);
            }
            return _project;
        }
    }
}
