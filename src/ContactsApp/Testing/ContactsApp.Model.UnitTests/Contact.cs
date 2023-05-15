using System;
using NUnit.Framework;
using ContactsApp.Model;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ContactTest
    {
        [Test(Description = "Позитивный тест геттера FullName")]
        public void TestFullNameGet_CorrectValue()
        {
            var expected = "Смирнов";
            var contact = new Contact();
            contact.FullName = expected;
            var actual = contact.FullName;

            Assert.AreEqual(expected, actual, "Геттер FullName возвращает неправильную фамилию");
        }

        [Test(Description = "Позитивный тест геттера Email")]
        public void TestEmailGet_CorrectValue()
        {
            var expected = "test@mail.ru";
            var contact = new Contact();
            contact.Email = expected;
            var actual = contact.Email;

            Assert.AreEqual(expected, actual, "Геттер Email возвращает неправильную фамилию");
        }

        [Test(Description = "Позитивный тест геттера Phone")]
        public void TestPhoneGet_CorrectValue()
        {
            var expected = "+79234427925";
            var contact = new Contact();
            contact.Phone = expected;
            var actual = contact.Phone;

            Assert.AreEqual(expected, actual, "Геттер Phone возвращает неправильную фамилию");
        }

        [Test(Description = "Позитивный тест геттера DateOfBirth")]
        public void TestDateOfBirthGet_CorrectValue()
        {
            var expected = new DateTime(2000,10,10);
            var contact = new Contact();
            contact.DateOfBirth = expected;
            var actual = contact.DateOfBirth;

            Assert.AreEqual(expected, actual, "Геттер DateOfBirth возвращает неправильную фамилию");
        }

        [Test(Description = "Позитивный тест геттера IdVk")]
        public void TestIdVkGet_CorrectValue()
        {
            var expected = "@id95471201";
            var contact = new Contact();
            contact.IdVk = expected;
            var actual = contact.IdVk;

            Assert.AreEqual(expected, actual, "Геттер IdVk возвращает неправильную фамилию");
        }

        [TestCase("Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов" +
   "-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов-Смирнов" +
   "-Смирнов-Смирнов-Смирнов-Смирнов-",
    "Должно возникать исключение, если полное имя длиннее 100 символов",
   TestName = "Присвоение неправильного полного имени больше 100 символов")]
        public void TestFullNameSet_ArgumentException(string wrongSurname, string message)
        {
            var contact = new Contact();
            Assert.Throws<ArgumentException>(
            () => { contact.FullName = wrongSurname; },
            message);
        }

        [TestCase("testtesttesttesttesttesttesttesttesttesttesttest" +
            "testtesttesttesttesttesttesttesttesttesttesttesttest" +
            "testtesttesttesttesttest@mail.ru",
            "Должно возникать исключение если почта длиннее 100 символов",
            TestName = "Присвоение неправильной почты больше 100 символов")]
        public void TestEmailSet_ArgumetnException(string wrongEmail, string messageEmail)
        {
            var contact = new Contact();
            Assert.Throws<ArgumentException>(
            () => { contact.Email = wrongEmail; },
            messageEmail);
        }
    }
}
