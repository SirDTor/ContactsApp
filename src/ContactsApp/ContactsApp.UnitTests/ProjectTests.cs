using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ContactsApp.Model;
using NUnit.Framework.Constraints;

namespace ContactsApp.UnitTests
{
    [TestFixture]
    public class ProjectTests
    {
        [TestCase("Метод сортировки контактов вернул неверные значения списка контактов",
            TestName = "Сортировки списка контактов")]
        public void Contacts_SortContactsByFullName_ReturnsValue(string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "C",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"),
                new Contact(
                    "B",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2010, 12, 12),
                    "@test"),
                new Contact(
                    "A",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2001, 12, 12),
                    "@test")
            };

            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact(
                    "A",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2001, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2010, 12, 12),
                    "@test"),
                new Contact(
                    "C",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test")
            };

            //Act
            var actual = new Project();
            actual.Contacts = project.SortContactsByFullName(project.Contacts);

            //Assert
            Assert.AreEqual(expected.Contacts.Count,
                       actual.Contacts.Count, message);
            for (int i = 0; i < expected.Contacts.Count; i++)
            {
                Assert.AreEqual(expected.Contacts[i].FullName,
                    actual.Contacts[i].FullName, message);
                Assert.AreEqual(expected.Contacts[i].Email,
                    actual.Contacts[i].Email, message);
                Assert.AreEqual(expected.Contacts[i].Phone,
                    actual.Contacts[i].Phone, message);
                Assert.AreEqual(expected.Contacts[i].DateOfBirth,
                    actual.Contacts[i].DateOfBirth, message);
                Assert.AreEqual(expected.Contacts[i].IdVk,
                    actual.Contacts[i].IdVk, message);
            }
        }

        [TestCase("Метод сортировки контактов вернул неверные значения списка контактов",
            TestName = "Сортировка пустого списка контактов")]
        public void Contacts_SortContactsWithoutValues_ReturnsValue(string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>();

            var expected = new Project();
            expected.Contacts = new List<Contact>();

            //Act
            var actual = new Project();
            actual.Contacts = project.SortContactsByFullName(project.Contacts);

            //Assert
            Assert.AreEqual(expected.Contacts,
                actual.Contacts, message);
        }

        [TestCase("Метод сортировки контактов вернул неверные значения списка контактов",
            TestName = "Сортировка отсортированного списка контактов")]
        public void Contacts_SortContactsByFullNameWithSortedListContacts_ReturnsValue(
            string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "A",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "C",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    )
            };

            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact(
                    "A",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"),
                new Contact(
                    "C",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test")
            };

            //Act
            var actual = new Project();
            actual.Contacts = project.SortContactsByFullName(project.Contacts);

            //Assert
            Assert.AreEqual(expected.Contacts.Count,
                       actual.Contacts.Count, message);
            for (int i = 0; i < expected.Contacts.Count; i++)
            {
                Assert.AreEqual(expected.Contacts[i].FullName,
                    actual.Contacts[i].FullName, message);
                Assert.AreEqual(expected.Contacts[i].Email,
                    actual.Contacts[i].Email, message);
                Assert.AreEqual(expected.Contacts[i].Phone,
                    actual.Contacts[i].Phone, message);
                Assert.AreEqual(expected.Contacts[i].DateOfBirth,
                    actual.Contacts[i].DateOfBirth, message);
                Assert.AreEqual(expected.Contacts[i].IdVk,
                    actual.Contacts[i].IdVk, message);
            }

        }

        [TestCase("Метод поиска именинников вернул неверное значения списка контактов",
            TestName = "Поиск именинников")]
        public void Contacts_FindBirthdayContacts_ReturnsValue(string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "A",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "C",
                    "test@mail.ru",
                    "+79234427925",
                    DateTime.Today,
                    "@test"
                    )
            };

            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact(
                    "C",
                    "test@mail.ru",
                    "+79234427925",
                    DateTime.Today,
                    "@test"
                    ),
            };

            //Act
            var actual = new Project();
            actual.Contacts = project.FindBirthdayContacts(project.Contacts);

            //Assert
            Assert.AreEqual(expected.Contacts.Count,
                       actual.Contacts.Count, message);
            for (int i = 0; i < expected.Contacts.Count; i++)
                {
                    Assert.AreEqual(expected.Contacts[i].FullName,
                        actual.Contacts[i].FullName, message);
                    Assert.AreEqual(expected.Contacts[i].Email,
                        actual.Contacts[i].Email, message);
                    Assert.AreEqual(expected.Contacts[i].Phone,
                        actual.Contacts[i].Phone, message);
                    Assert.AreEqual(expected.Contacts[i].DateOfBirth,
                        actual.Contacts[i].DateOfBirth, message);
                    Assert.AreEqual(expected.Contacts[i].IdVk,
                        actual.Contacts[i].IdVk, message);
                }
        }

        [TestCase("Метод поиска именинников вернул неверное значения списка контактов",
            TestName = "Поиск именинников если сегодня их нет")]
        public void Contacts_FindBirthdayContactsWithoutBirthdayContacts_ReturnsValue(string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "A",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "C",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    )
            };

            var expected = new Project();
            expected.Contacts = new List<Contact>();

            //Act
            var actual = new Project();
            actual.Contacts = project.FindBirthdayContacts(project.Contacts);

            //Assert
            Assert.AreEqual(expected.Contacts,
               actual.Contacts, message);
        }

        [TestCase("Метод поиска именинников вернул неверное значения списка контактов",
            TestName = "Поиск именинников если список контактов пустой")]
        public void Contacts_FindBirthdayContactsWithEmptyListContacts_ReturnsValue(string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>();

            var expected = new Project();
            expected.Contacts = new List<Contact>();

            //Act
            var actual = new Project();
            actual.Contacts = project.FindBirthdayContacts(project.Contacts);

            //Assert
            Assert.AreEqual(expected.Contacts,
               actual.Contacts, message);
        }

        [TestCase("Смирнов", "Метод поиска контактов возвращает неверные значения списка контактов",
            TestName = "Поиск контактов")]
        public void Contacts_FindContacts_ReturnsValue(string contactName, string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "C",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    )
            };

            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    )
            };

            //Act
            var actual = new Project();
            actual.Contacts = project.FindContacts(project.Contacts, contactName);

            //Assert
            Assert.AreEqual(expected.Contacts.Count,
                       actual.Contacts.Count, message);
            for (int i = 0; i < expected.Contacts.Count; i++)
                {
                    Assert.AreEqual(expected.Contacts[i].FullName,
                        actual.Contacts[i].FullName, message);
                    Assert.AreEqual(expected.Contacts[i].Email,
                        actual.Contacts[i].Email, message);
                    Assert.AreEqual(expected.Contacts[i].Phone,
                        actual.Contacts[i].Phone, message);
                    Assert.AreEqual(expected.Contacts[i].DateOfBirth,
                        actual.Contacts[i].DateOfBirth, message);
                    Assert.AreEqual(expected.Contacts[i].IdVk,
                        actual.Contacts[i].IdVk, message);
                }
        }

        [TestCase("Смирнов", "Метод поиска контактов возвращает неверные значения списка контактов",
            TestName = "Поиск контактов в пустом списке контактов")]
        public void Contacts_FindContactsWithEmptyListContacts_ReturnsValue(string contactName, string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>();

            var expected = new Project();
            expected.Contacts = new List<Contact>();

            //Act
            var actual = new Project();
            actual.Contacts = project.FindContacts(project.Contacts, contactName);

            //Assert
            Assert.AreEqual(expected.Contacts,
               actual.Contacts, message);
        }

        [TestCase("", "Метод поиска контактов возвращает неверные значения списка контактов",
            TestName = "Поиск контактов с пустым искомым контактом")]
        public void Contacts_FindContactsWithEmptySubstring_ReturnsValue(string contactName, string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "C",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    )
            };

            var expected = new Project();
            expected.Contacts = new List<Contact>()
            {
                new Contact(
                    "Смирнов",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "B",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    ),
                new Contact(
                    "C",
                    "test@mail.ru",
                    "+79234427925",
                    new DateTime(2000, 12, 12),
                    "@test"
                    )
            };

            //Act
            var actual = new Project();
            actual.Contacts = project.FindContacts(project.Contacts, contactName);

            //Assert
            Assert.AreEqual(expected.Contacts.Count,
                       actual.Contacts.Count, message);
            for (int i = 0; i < expected.Contacts.Count; i++)
                {
                    Assert.AreEqual(expected.Contacts[i].FullName,
                        actual.Contacts[i].FullName, message);
                    Assert.AreEqual(expected.Contacts[i].Email,
                        actual.Contacts[i].Email, message);
                    Assert.AreEqual(expected.Contacts[i].Phone,
                        actual.Contacts[i].Phone, message);
                    Assert.AreEqual(expected.Contacts[i].DateOfBirth,
                        actual.Contacts[i].DateOfBirth, message);
                    Assert.AreEqual(expected.Contacts[i].IdVk,
                        actual.Contacts[i].IdVk, message);
                }
        }

        [TestCase("", "Метод поиска контактов возвращает неверные значения списка контактов",
            TestName = "Поиск контактов в пустом списке контактов" +
            "с пустым искомым контактом")]
        public void Contacts_FindContactsWithEmptyListContactsWithoutSubstring_ReturnsValue(string contactName, string message)
        {
            //Arrange
            var project = new Project();
            project.Contacts = new List<Contact>();

            var expected = new Project();
            expected.Contacts = new List<Contact>();

            //Act
            var actual = new Project();
            actual.Contacts = project.FindContacts(project.Contacts, contactName);

            //Assert
            Assert.AreEqual(expected.Contacts,
               actual.Contacts, message);
        }
    }
}
