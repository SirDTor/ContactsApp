using System;
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
        /// 
        /// </summary>
        private static string[] _arrSurname = {"Смирнов","Долгов","Беспалов","Малышев","Толкачев",
            "Лазарев","Яковлев","Демин","Журавлев","Кондрашов" };

        /// <summary>
        /// 
        /// </summary>
        private static string[] _arrMaleName = {"Тимур", "Михаил", "Иван", "Дмитрий", "Николай", "Тимофей" };

        /// <summary>
        /// 
        /// </summary>
        private static string[] _arrFemaleName = {"София","Анна","Полина","Елизавета", "Александра","Анна" };

        /// <summary>
        /// 
        /// </summary>
        private static string[] _arrPatronymic = {"Алексеев","Матвеев","Михайлов","Егоров",
            "Алексеев","Григорьев","Александров","Глебов" };

        /// <summary>
        /// 
        /// </summary>
        private static string[] _fullName = new string [20];

        /// <summary>
        /// 
        /// </summary>
        private static string[] _email = { "o@outlook.com","hr6zdl@yandex.ru","kaft93x@outlook.com","dcu@yandex.ru","19dn@outlook.com","pa5h@mail.ru",
            "281av0@gmail.com","8edmfh@outlook.com","sfn13i@mail.ru","g0orc3x1@outlook.com","rv7bp@gmail.com","93@outlook.com",
            "er@gmail.com","o0my@gmail.com","715qy08@gmail.com","vubx0t@mail.ru","wnhborq@outlook.com","gq@yandex.ru",
            "ic0pu@outlook.com","o7khr@yandex.ru"};

        /// <summary>
        /// 
        /// </summary>
        private static string[] _phone = { "8(923)480-65-83","8(923)234-84-20","8(923)136-38-75",
            "8(923)653-03-02","8(923)824-41-77","8(923)112-54-20","8(923)678-54-33","8(923)971-37-41",
            "8(923)760-83-72","8(923)950-38-18"};

        private static string[] _idVk = { "id8626810", "id2307938", "id7027388", "id6938923", "id2570718",
            "id7381412", "id1153817", "id7013733", "id8111215", "id6492395" };


        /// <summary>
        /// 
        /// </summary>
        /// <param name="rnd"></param>
        /// <param name="lengthOfArray"></param>
        /// <returns></returns>
        private static int GenerateDigit(Random _rnd,int lengthOfArray)
        {
            return _rnd.Next(lengthOfArray);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rnd"></param>
        /// <param name="randomContacts"></param>
        /// <returns></returns>
        public static List<Contact> GenerateRandomContactsName(Random _rnd, Project project)
        {

            for (int i = 0; i <= 10; i++)
            {
                _fullName[i] = _arrSurname[GenerateDigit(_rnd, _arrSurname.Length)]+ " " +
                    _arrMaleName[GenerateDigit(_rnd, _arrMaleName.Length)] + " "
                    + _arrPatronymic[GenerateDigit(_rnd, _arrPatronymic.Length)]+"ич";
                
            }
            for (int i = 11; i < 20; i++)
            {
                _fullName[i] = _arrSurname[GenerateDigit(_rnd, _arrSurname.Length)] + "а " +
                    _arrFemaleName[GenerateDigit(_rnd, _arrFemaleName.Length)] + " "
                    + _arrPatronymic[GenerateDigit(_rnd, _arrPatronymic.Length)] + "на";

            }
            for (int i = 0; i < 20; i++ )
            {
                Contact contact = new Contact(_fullName[GenerateDigit(_rnd, _fullName.Length)],
                _email[GenerateDigit(_rnd, _email.Length)],
                    _phone[GenerateDigit(_rnd, _phone.Length)], DateTime.Today,
                    _idVk[GenerateDigit(_rnd, _idVk.Length)]);

                project.Contacts.Add(contact);
            }
 
            return project.Contacts;
        }
    }
}
