using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactsApp.Model;
using System.Diagnostics.Eventing.Reader;

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле класса <see cref="Project"> 
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Список класса <see cref="Contact"> 
        /// Хранит данные контактов
        /// используется для сортировки и поиска контактов
        /// </summary>
        private List<Contact> _currentContacts = new List<Contact>();

        /// <summary>
        /// Список класса <see cref="Contact">
        /// Хранит контакты у которых сегодня день рождения
        /// </summary>
        private List<Contact> _birthdayContacts = new List<Contact>();

        /// <summary>
        /// Метод по обновлению списка контактов
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();

            _project.Contacts = _project.SortContactsByFullName(_project.Contacts);
            _currentContacts = _project.FindContacts(_project.Contacts, FindTextBox.Text);

            foreach (Contact currentContactList in _currentContacts)
            {
                ContactsListBox.Items.Add(currentContactList.FullName);
            }
            UpdateBirthdayPanel();
        }

        /// <summary>
        /// Метод выводящий в текстовое поле именниников
        /// </summary>
        private void UpdateBirthdayPanel()
        {
            BirthdaySurnameLabel.Text = null;
            if (_project.Contacts.Count != 0)
            {
                _birthdayContacts = _project.FindBirthdayContacts(_project.Contacts);
                if (_birthdayContacts.Count != 0)
                {
                    for (int i = 0; i < _birthdayContacts.Count; i++)
                    {
                        BirthdaySurnameLabel.Text += $"{_birthdayContacts[i].FullName}, ";
                        if (i >= 3)
                        {
                            BirthdaySurnameLabel.Text += "и т.д.";
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Метод добавляющий новый контакт в список
        /// </summary>
        private void AddContact()
        {
            var addForm = new ContactForm();
            addForm.ShowDialog();
            var updatedData = addForm.Contact;
            if (addForm.DialogResult == DialogResult.OK)
            {
                _project.Contacts.Add(updatedData);
            }
        }

        /// <summary>
        /// Метод добавляющий случайные контакты в список
        /// </summary>
        private void AddRandomContacts()
        {
            _project.Contacts.AddRange(RandomContacts.GenerateRandomContactsName());
        }

        /// <summary>
        /// Метод редактирующий выбранный в списке контакт
        /// </summary>
        /// <param name="index"></param>
        private void EditContact(int index)
        {
            var cloneContact = (Contact)_currentContacts[index].Clone();
            var contactForm = new ContactForm();
            contactForm.Contact = cloneContact;
            contactForm.ShowDialog();
            if (contactForm.DialogResult == DialogResult.OK)
            {
                var updatedData = contactForm.Contact;
                ContactsListBox.Items.RemoveAt(index);

                int indexInProject = _project.Contacts.IndexOf(_currentContacts[index]);
                _project.Contacts.RemoveAt(indexInProject);
                _project.Contacts.Insert(indexInProject, updatedData);
            }
        }

        /// <summary>
        /// Метод удаления контакта из списка
        /// </summary>
        /// <param name="index"></param>
        private void RemoveContact(int index)
        {
            if (index == -1) return;
            string message = $"Do you really want to remove {_currentContacts[index].FullName}?";
            string caption = "Delete contact";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            int indexInProject = _project.Contacts.IndexOf(_currentContacts[index]);
            if (result == DialogResult.Yes)
            {
                _project.Contacts.RemoveAt(indexInProject);
            }
        }

        /// <summary>
        /// Метод обновления данных о контакте в правой панели программы
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            Contact selectedContact = _currentContacts[index];

            FullNameTextBox.Text = selectedContact.FullName;
            EmailTextBox.Text = selectedContact.Email;
            PhoneNumberTextBox.Text = selectedContact.Phone;
            DateOfBirthTextBox.Text = selectedContact.DateOfBirth.GetDateTimeFormats('d')[0];
            VkTextbox.Text = selectedContact.IdVk;
        }

        /// <summary>
        /// Метод очистки данных о контакте в правой панели программы
        /// </summary>
        private void ClearSelectedContact()
        {
            FullNameTextBox.Text = null;
            EmailTextBox.Text = null;
            PhoneNumberTextBox.Text = null;
            DateOfBirthTextBox.Text = null;
            VkTextbox.Text = null;
        }

        public MainForm()
        {
            InitializeComponent();
            _project = ProjectSerializer.LoadFromFile();
            UpdateListBox();
        }

        private void AddRandomContactPictureBox_Click(object sender, EventArgs e)
        {
            AddRandomContacts();
            ProjectSerializer.SaveToFile(_project);
            UpdateListBox();
        }

        private void AddContactPictureBox_Click(object sender, EventArgs e)
        {
            AddContact();
            ProjectSerializer.SaveToFile(_project);
            UpdateListBox();
        }

        private void EditContactPictureBox_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1)
            {
                MessageBox.Show("Contact is not selected",
                "Attention", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                EditContact(ContactsListBox.SelectedIndex);
                UpdateListBox();
                ProjectSerializer.SaveToFile(_project);
            }
        }

        private void RemoveContactPictureBox_Click(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1) return;
            RemoveContact(ContactsListBox.SelectedIndex);
            ClearSelectedContact();
            ProjectSerializer.SaveToFile(_project);
            UpdateListBox();
        }

        private void ContactsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ContactsListBox.SelectedIndex == -1)
            {
                ClearSelectedContact();
            }
            else UpdateSelectedContact(ContactsListBox.SelectedIndex);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProjectSerializer.SaveToFile(_project);
            e.Cancel = MessageBox.Show("Do you really want to close program?",
            "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void AddContactPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddContactPictureBox.Image = Properties.Resources.add_contact_32x32;
            AddContactPictureBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5FF");
        }

        private void AddContactPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddContactPictureBox.Image = Properties.Resources.add_contact_32x32_gray;
            AddContactPictureBox.BackColor = Color.White;
        }

        private void EditContactPictureBox_MouseEnter(object sender, EventArgs e)
        {
            EditContactPictureBox.Image = Properties.Resources.edit_contact_32x32;
            EditContactPictureBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5FF");
        }

        private void EditContactPictureBox_MouseLeave(object sender, EventArgs e)
        {
            EditContactPictureBox.Image = Properties.Resources.edit_contact_32x32_gray;
            EditContactPictureBox.BackColor = Color.White;
        }

        private void RemoveContactPictureBox_MouseEnter(object sender, EventArgs e)
        {
            RemoveContactPictureBox.Image = Properties.Resources.remove_contact_32x32;
            RemoveContactPictureBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#FAF5F5");
        }

        private void RemoveContactPictureBox_MouseLeave(object sender, EventArgs e)
        {
            RemoveContactPictureBox.Image = Properties.Resources.remove_contact_32x32_gray;
            RemoveContactPictureBox.BackColor = Color.White;
        }

        private void FullNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void EmailTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void DateOfBirthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void VkTextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                var FormAbout = new AboutForm();
                FormAbout.ShowDialog();
            }
            if (e.KeyCode == Keys.Delete)
            {
                RemoveContact(ContactsListBox.SelectedIndex);
                ProjectSerializer.SaveToFile(_project);
                UpdateListBox();
            }
        }

        private void BirthdayPanelCloseButton_Click(object sender, EventArgs e)
        {
            BirthdayPanel.Visible = false;
            UpBirthdayPanel.Visible = true;
        }

        private void PanelUpPictureBox_Click(object sender, EventArgs e)
        {
            UpBirthdayPanel.Visible = false;
            BirthdayPanel.Visible = true;
        }
    }
}
