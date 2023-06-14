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

        /// <summary>
        /// Цвет ошибки correctBackColor
        /// </summary>
        private static Color _errorColorInTextBox = Color.LightPink;

        /// <summary>
        /// Цвет отсутсвия ошибки errirBackColor
        /// </summary>
        private static Color _noErrorColorInTextBox = Color.White;

        public ContactForm()
        {
            InitializeComponent();
            //UpdateForm();
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
            string fullError = null;
            fullError += _fullNameError + _emailError + _phoneError + _dateError + _idVkError;
            if (fullError != null && fullError != "")
            {
                fullError = null;
                string[] arrayOfErrors = {_fullNameError, _emailError, _phoneError, 
                    _dateError, _idVkError};
                for (int i = 0; i < arrayOfErrors.Length; i++)
                {
                    if (arrayOfErrors[i] != null)
                    {
                        fullError += $"{arrayOfErrors[i]}\n";
                    }
                }
                MessageBox.Show(fullError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                FullNameTextBox.BackColor = _noErrorColorInTextBox;
            }
            catch (Exception exception)
            {
                _fullNameError = exception.Message;
                FullNameTextBox.BackColor = _errorColorInTextBox;
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
                EmailTextBox.BackColor = _noErrorColorInTextBox;
            }
            catch (Exception exception)
            {
                _emailError = exception.Message;
                EmailTextBox.BackColor = _errorColorInTextBox;
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
                DateOfBirthTimePicker.CalendarForeColor = _noErrorColorInTextBox;
            }
            catch (Exception exception)
            {
                _dateError = exception.Message;
                DateOfBirthTimePicker.CalendarForeColor = _errorColorInTextBox;
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
                VkTextBox.BackColor = _noErrorColorInTextBox;
            }
            catch (Exception exception)
            {
                VkTextBox.BackColor = _errorColorInTextBox;
                _idVkError = exception.Message;
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
                PhoneNumberTextBox.BackColor = _noErrorColorInTextBox;
            }
            catch (Exception exception)
            {
                _phoneError = exception.Message;
                PhoneNumberTextBox.BackColor = _errorColorInTextBox;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            bool isNoErrorsOnForm = CheckFormOnErrors();
            if (isNoErrorsOnForm)
            {
                UpdateContact();
                DialogResult = DialogResult.OK;
                this.Close();
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
    }
}
