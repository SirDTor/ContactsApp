using System;
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

namespace ContactsApp.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле класса Project 
        /// </summary>
        private Project _project = new Project();

        /// <summary>
        /// Переменная для генерации рандомного числа
        /// </summary>
        Random rng = new Random();

        /// <summary>
        /// Метод по обновлению списка контактов
        /// </summary>
        private void UpdateListBox()
        {
            int i = 0;
            ContactsListBox.Items.Clear();
            foreach (Contact contactList in _project.Contacts)
            {
                ContactsListBox.Items.Insert(i++,contactList.FullName);
            }
        }

        /// <summary>
        /// Метод добавляющий контакт в список
        /// </summary>
        private void AddContact()
        {
            
            string[] arrContactName = { "ЗоРиН", "ГавРилов", "КурБанов", "базкен", "кочетов" };
            string[] arrContactEmail = { "dannl@gmail.com", "zordl@mail.ru", "petsp@no.mail", "test@mail.ru", "asdas@mail.ru" };
            string[] arrContactPhone = { "89234427925", "7(495)733-26-31", "7(495)840-47-17", "7(495)467-21-28", "7(495)859-56-70" };
            string[] arrContactIdVk = { "@123412", "@sirdktor", "@test", "@id12312", "@00000" };


            //var listContact = new List<Contact>();
            int randomContact;

            for (int i = 0; i < 6; i++)
            {
                randomContact = GenerateDigit(rng);
                Contact contact = new Contact(arrContactName[randomContact], arrContactEmail[randomContact],
                    arrContactPhone[randomContact], DateTime.Today, arrContactIdVk[randomContact]);
                //listContact.Add(contact);
                _project.Contacts.Add(contact);
            }
            //_project.Contacts.AddRange(listContact);
        }

        /// <summary>
        /// Метод генерации рандомного числа
        /// </summary>
        /// <param name="rng"></param>
        /// <returns></returns>
        static int GenerateDigit(Random rng)
        {
            return rng.Next(5);
        }

        /// <summary>
        /// Метод удаления контакта из списка
        /// </summary>
        /// <param name="index"></param>
        private void RemoveContact(int index)
        {
            if (index == -1) return;

            string message = $"Do you really want to remove {_project.Contacts[index].FullName}?";
            string caption = "Delete contact";
            DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                _project.Contacts.RemoveAt(index);
            }
            
        }

        /// <summary>
        /// Метод обновления данных о контакте в правой панели программы
        /// </summary>
        /// <param name="index"></param>
        private void UpdateSelectedContact(int index)
        {
            FullNameTextBox.Text = _project.Contacts[index].FullName;
            EmailTextBox.Text = _project.Contacts[index].Email;
            PhoneNumberTextBox.Text = _project.Contacts[index].Phone;
            DateOfBirthTextBox.Text = _project.Contacts[index].DateOfBirth.ToString();
            VkTextbox.Text = _project.Contacts[index].IdVk;
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
            var AddForm = new ContactForm();
            AddForm.ShowDialog();

        }

        private void EditContactPictureBox_Click(object sender, EventArgs e)
        {
            var EditForm = new ContactForm();
            EditForm.ShowDialog();
        }

        private void RemoveContactPictureBox_Click(object sender, EventArgs e)
        {
            RemoveContact(ContactsListBox.SelectedIndex);
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
            PanelUp.Visible = true;
        }

        private void panelUpPictureBox_Click(object sender, EventArgs e)
        {
            PanelUp.Visible = false;
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
    }
}
