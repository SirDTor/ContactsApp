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
        private List<Contact> _currentContact = new List<Contact>();

        /// <summary>
        /// Список класса <see cref="Contact">
        /// Хранит контакты у которых сегодня день рождения
        /// </summary>
        private List<Contact> _birthdayContacts = new List<Contact>();

        /// <summary>
        /// Переменная для генерации рандомного числа
        /// </summary>
        private Random _rng = new Random();

        /// <summary>
        /// Метод по обновлению списка контактов
        /// </summary>
        private void UpdateListBox()
        {
            ContactsListBox.Items.Clear();
            _project.Contacts = _project.SortContactsBySurname(_project.Contacts);
            _currentContact = _project.Contacts;
            if (FindTextBox.Text != "")
            {
                _currentContact = _project.FindContact(_project.Contacts, FindTextBox.Text);
                foreach (Contact currentContactList in _currentContact)
                {
                    ContactsListBox.Items.Add(currentContactList.FullName);
                }
            }
            else
            {
                foreach (Contact projectContactList in _project.Contacts)
                {
                    ContactsListBox.Items.Add(projectContactList.FullName);
                }
            }

            UpdateBirthdayPanel();
        }

        /// <summary>
        /// Метод выводящий в текстовое поле именниников
        /// </summary>
        private void UpdateBirthdayPanel()
        {
            BirthdaySurnameLabel.Text = null;

            _birthdayContacts = _project.FindBirhdayContact(_project.Contacts);

            for (int i = 0; i < 3; i++)
            {
                BirthdaySurnameLabel.Text += $"{_birthdayContacts[i].FullName}, ";
            }
            BirthdaySurnameLabel.Text += "и т.д.";
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
            //_project.Contacts.AddRange(RandomContacts.GenerateRandomContactsName(_rng, _project));
            RandomContacts.GenerateRandomContactsName(_rng, _project);
        }

        /// <summary>
        /// Метод редактирующий выбранный в списке контакт
        /// </summary>
        /// <param name="index"></param>
        private void EditContact(int index)
        {
            var cloneContact = (Contact)_currentContact[index].Clone();
            var editForm = new ContactForm();
            editForm.Contact = cloneContact;
            editForm.ShowDialog();
            if (editForm.DialogResult == DialogResult.OK)
            {
                var updatedData = editForm.Contact;
                ContactsListBox.Items.RemoveAt(index);
                for (int i = 0; i < _project.Contacts.Count; i++)
                {
                    if (_project.Contacts[i].FullName == _currentContact[index].FullName
                        && _project.Contacts[i].Phone == _currentContact[index].Phone
                        && _project.Contacts[i].Email == _currentContact[index].Email
                        && _project.Contacts[i].IdVk == _currentContact[index].IdVk)
                    {
                        _project.Contacts.RemoveAt(i);
                        _project.Contacts.Insert(i, updatedData);
                        break;
                    }
                }
            }
            else if (editForm.DialogResult == DialogResult.Cancel) { return; }
        }

        /// <summary>
        /// Метод удаления контакта из списка
        /// </summary>
        /// <param name="index"></param>
        private void RemoveContact(int index)
        {
            if (index == -1) return;

            string message = $"Do you really want to remove {_currentContact[index].FullName}?";
            string caption = "Delete contact";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            for (int i = 0; i < _project.Contacts.Count; i++)
            {
                if (_project.Contacts[i].FullName == _currentContact[index].FullName
                    && _project.Contacts[i].Phone == _currentContact[index].Phone
                    && result == DialogResult.Yes)
                {
                    _project.Contacts.RemoveAt(i);
                    break;
                }
            }
        }

        /// <summary>
        /// Метод обновления данных о контакте в правой панели программы
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            FullNameTextBox.Text = _currentContact[index].FullName;
            EmailTextBox.Text = _currentContact[index].Email;
            PhoneNumberTextBox.Text = _currentContact[index].Phone;
            DateOfBirthTextBox.Text = _currentContact[index].DateOfBirth.GetDateTimeFormats('d')[0];
            VkTextbox.Text = _currentContact[index].IdVk;
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
            this.KeyPreview = true;
        }

        private void AddContactPictureBox_Click(object sender, EventArgs e)
        {
            AddContact();
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
            }
        }

        private void RemoveContactPictureBox_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
            ClearSelectedContact();
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
            e.Cancel = MessageBox.Show("Do you really want to close program?",
            "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;
        }

        private void AddRandomContactPictureBox_Click(object sender, EventArgs e)
        {
            AddRandomContacts();
            UpdateListBox();
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateListBox();
        }
    }
}
