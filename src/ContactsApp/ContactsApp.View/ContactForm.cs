using ContactsApp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        /// 
        /// </summary>
        private Contact _contact = new Contact();

        /// <summary>
        /// 
        /// </summary>
        private string _fullNameError;

        /// <summary>
        /// 
        /// </summary>
        private string _emailError;

        /// <summary>
        /// 
        /// </summary>
        private string _phoneError;

        /// <summary>
        /// 
        /// </summary>
        private string _dateError;

        /// <summary>
        /// 
        /// </summary>
        private string _idVkError;

        public ContactForm()
        {
            InitializeComponent();
            _contact.DateOfBirth = new DateTime (2000,1,1);
            UpdateForm();
        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        private void UpdateContact()
        {
            _contact.FullName = FullNameTextBox.Text;
            _contact.Email = EmailTextBox.Text;
            _contact.Phone = PhoneNumberTextBox.Text;
            _contact.DateOfBirth = DateOfBirthTimePicker.Value;
            _contact.IdVk = VkTextBox.Text;
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            CheckFormOnErrors();
            UpdateContact();
        }

        private void AddPhotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
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
        /// 
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
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="ArgumentException"></exception>
        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            //if (PhoneNumberTextBox.TextLength == 11)
            //{
            //    try
            //    {
            //        _contact.Phone = PhoneNumberTextBox.Text;
            //        _phoneError = null;
            //        PhoneNumberTextBox.BackColor = Color.White;
            //    }
            //    catch (Exception ex)
            //    {
            //        _phoneError = ex.Message;
            //        PhoneNumberTextBox.BackColor = Color.LightPink;
            //        throw new ArgumentException(ex.Message);
            //    }
            //}
        }

        /// <summary>
        /// 
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
                DateOfBirthTimePicker.BackColor = Color.White;
            }
            catch (Exception ex)
            {
                _dateError = ex.Message;
                DateOfBirthTimePicker.BackColor = Color.LightPink;
                throw new ArgumentException(ex.Message);
            }
        }

        /// <summary>
        /// 
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
                throw new ArgumentException(ex.Message);
            }
        }
    }
}
