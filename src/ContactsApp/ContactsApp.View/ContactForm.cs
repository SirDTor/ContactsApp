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
        public ContactForm()
        {
            InitializeComponent();
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
            this.Close();
        }

        private void AddPhotoPictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
