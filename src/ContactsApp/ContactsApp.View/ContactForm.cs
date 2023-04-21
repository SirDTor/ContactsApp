using ContactsApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactsApp.View
{
    public partial class ContactForm : Form
    {
        /// <summary>
        /// Поле класса <see cref="Contact">
        /// </summary>
        private Contact _contact = new Contact("", "", "89234427925",
            new DateTime(2000, 1, 1), "");

        /// <summary>
        /// Установка и получение экземпляра <see cref="Contact">
        /// </summary>
        public Contact Contact
        {
            get => _contact;
            set
            {
                _contact = value;
                UpdateForm();
            }
        }

        /// <summary>
        /// строка хранаящая ошибку ФИО
        /// </summary>
        private string _fullNameError;

        /// <summary>
        /// строка хранаящая ошибку email
        /// </summary>
        private string _emailError;

        /// <summary>
        /// строка хранаящая ошибку номера телефона
        /// </summary>
        private string _phoneError;

        /// <summary>
        /// строка хранаящая ошибку даты
        /// </summary>
        private string _dateError;

        /// <summary>
        /// строка хранаящая ошибку idVK
        /// </summary>
        private string _idVkError;

        public ContactForm()
        {
            InitializeComponent();
            UpdateForm();
        }

        /// <summary>
        /// Метод обновляющий текстовые поля
        /// </summary>
        private void UpdateForm()
        {
            FullNameTextBox.Text = _contact.FullName;
            EmailTextBox.Text = _contact.Email;
            PhoneNumberTextBox.Text = _contact.Phone;
            DateOfBirthTimePicker.Value = _contact.DateOfBirth;
            VkTextBox.Text = _contact.IdVk;

        }

        /// <summary>
        /// Метод возвращает false если в веденных данных есть ошибка
        /// </summary>
        /// <returns></returns>
        private bool CheckFormOnErrors()
        {
            string strError = null;
            strError += _fullNameError;
            strError += _emailError;
            strError += _phoneError;
            strError += _dateError;
            strError += _idVkError;
            if (strError != null && strError != "")
            {
                MessageBox.Show($"{_fullNameError}\n{_emailError}\n{_phoneError}\n{_dateError}\n{_idVkError}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else return true;
        }

        /// <summary>
        /// Метод обновляющий данные класса Contact
        /// </summary>
        private void UpdateContact()
        {
            _contact.FullName = FullNameTextBox.Text;
            _contact.Email = EmailTextBox.Text;
            _contact.Phone = PhoneNumberTextBox.Text;
            _contact.DateOfBirth = DateOfBirthTimePicker.Value;
            _contact.IdVk = VkTextBox.Text;
        }

        /// <summary>
        /// Валидация данных ФИО
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException"></exception>
        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.FullName = FullNameTextBox.Text;
                _fullNameError = null;
                FullNameTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                _fullNameError = ex.Message;
                FullNameTextBox.BackColor = Color.LightPink;
                throw new ArgumentException(ex.Message);
            }
        }

        /// <summary>
        /// Валидация данных email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException"></exception>
        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.Email = EmailTextBox.Text;
                _emailError = null;
                EmailTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                _emailError = ex.Message;
                EmailTextBox.BackColor = Color.LightPink;
                throw new ArgumentException(ex.Message);
            }
        }

        /// <summary>
        /// Валидация данных даты рождения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException"></exception>
        private void DateOfBirthTimePicker_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.DateOfBirth = DateOfBirthTimePicker.Value;
                _dateError = null;
                DateOfBirthTimePicker.CalendarForeColor = Color.White;
            }
            catch (Exception ex)
            {
                _dateError = ex.Message;
                DateOfBirthTimePicker.CalendarForeColor = Color.LightPink;
                throw new ArgumentException(ex.Message);
            }
        }

        /// <summary>
        /// Валидация данных idVK
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException"></exception>
        private void VkTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _contact.IdVk = VkTextBox.Text;
                _idVkError = null;
                VkTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                VkTextBox.BackColor = Color.LightPink;
                _idVkError = ex.Message;
                throw new ArgumentException(ex.Message);
            }
        }

        /// <summary>
        /// Валидация данных номера телефона
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException"></exception>
        private void PhoneNumberTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                _contact.Phone = PhoneNumberTextBox.Text;
                _phoneError = null;
                PhoneNumberTextBox.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                _phoneError = ex.Message;
                PhoneNumberTextBox.BackColor = Color.LightPink;
                throw new ArgumentException(_phoneError);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            bool ErrorsInContactForm = CheckFormOnErrors();
            if (ErrorsInContactForm == true)
            {
                DialogResult = DialogResult.OK;
                UpdateContact();
                this.Close();
            }
            else if (ErrorsInContactForm == false)
            {
                DialogResult = DialogResult.Ignore;
            }
        }

        private void AddPhotoPictureBox_MouseEnter(object sender, EventArgs e)
        {
            AddPhotoPictureBox.Image = Properties.Resources.add_photo_32x32;
            AddPhotoPictureBox.BackColor = System.Drawing.ColorTranslator.FromHtml("#F5F5FF");
        }

        private void AddPhotoPictureBox_MouseLeave(object sender, EventArgs e)
        {
            AddPhotoPictureBox.Image = Properties.Resources.add_photo_32x32_gray;
            AddPhotoPictureBox.BackColor = Color.White;
        }

        private void AddPhotoPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
