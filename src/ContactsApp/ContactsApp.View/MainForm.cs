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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void AddContactPictureBox_Click(object sender, EventArgs e)
        {
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
    }
}
