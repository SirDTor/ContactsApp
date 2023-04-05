namespace ContactsApp.View
{
    partial class ContactForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ContactPictureBox = new System.Windows.Forms.PictureBox();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FulNamelabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.DateOfBirthTimePicker = new System.Windows.Forms.DateTimePicker();
            this.VkLabel = new System.Windows.Forms.Label();
            this.VkTextBox = new System.Windows.Forms.TextBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddPhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContactPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 341);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AddPhotoPictureBox);
            this.panel1.Controls.Add(this.VkLabel);
            this.panel1.Controls.Add(this.VkTextBox);
            this.panel1.Controls.Add(this.DateOfBirthTimePicker);
            this.panel1.Controls.Add(this.DateOfBirthLabel);
            this.panel1.Controls.Add(this.PhoneNumberLabel);
            this.panel1.Controls.Add(this.PhoneNumberTextBox);
            this.panel1.Controls.Add(this.EmailLabel);
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.FulNamelabel);
            this.panel1.Controls.Add(this.FullNameTextBox);
            this.panel1.Controls.Add(this.ContactPictureBox);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 341);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.CancelButton);
            this.panel2.Controls.Add(this.OkButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 296);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 45);
            this.panel2.TabIndex = 0;
            // 
            // ContactPictureBox
            // 
            this.ContactPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.ContactPictureBox.Location = new System.Drawing.Point(12, 12);
            this.ContactPictureBox.Margin = new System.Windows.Forms.Padding(12, 12, 3, 3);
            this.ContactPictureBox.Name = "ContactPictureBox";
            this.ContactPictureBox.Size = new System.Drawing.Size(100, 100);
            this.ContactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ContactPictureBox.TabIndex = 1;
            this.ContactPictureBox.TabStop = false;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameTextBox.Location = new System.Drawing.Point(121, 43);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(384, 22);
            this.FullNameTextBox.TabIndex = 2;
            this.FullNameTextBox.Text = "Абакумов Владимир";
            // 
            // FulNamelabel
            // 
            this.FulNamelabel.AutoSize = true;
            this.FulNamelabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FulNamelabel.Location = new System.Drawing.Point(121, 24);
            this.FulNamelabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.FulNamelabel.Name = "FulNamelabel";
            this.FulNamelabel.Size = new System.Drawing.Size(61, 13);
            this.FulNamelabel.TabIndex = 3;
            this.FulNamelabel.Text = "Full Name:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(121, 71);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(6, 0, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(41, 13);
            this.EmailLabel.TabIndex = 5;
            this.EmailLabel.Text = "E-mail:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(121, 90);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(384, 22);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.Text = "abakumov@no.mail";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(121, 124);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(87, 13);
            this.PhoneNumberLabel.TabIndex = 7;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(121, 143);
            this.PhoneNumberTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(177, 22);
            this.PhoneNumberTextBox.TabIndex = 6;
            this.PhoneNumberTextBox.Text = "+7 (000) 000-00-00";
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirthLabel.Location = new System.Drawing.Point(121, 175);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(75, 13);
            this.DateOfBirthLabel.TabIndex = 9;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // DateOfBirthTimePicker
            // 
            this.DateOfBirthTimePicker.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirthTimePicker.Location = new System.Drawing.Point(121, 191);
            this.DateOfBirthTimePicker.Name = "DateOfBirthTimePicker";
            this.DateOfBirthTimePicker.Size = new System.Drawing.Size(177, 22);
            this.DateOfBirthTimePicker.TabIndex = 10;
            this.DateOfBirthTimePicker.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // VkLabel
            // 
            this.VkLabel.AutoSize = true;
            this.VkLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VkLabel.Location = new System.Drawing.Point(121, 220);
            this.VkLabel.Margin = new System.Windows.Forms.Padding(6, 6, 3, 0);
            this.VkLabel.Name = "VkLabel";
            this.VkLabel.Size = new System.Drawing.Size(23, 13);
            this.VkLabel.TabIndex = 12;
            this.VkLabel.Text = "VK:";
            // 
            // VkTextBox
            // 
            this.VkTextBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VkTextBox.Location = new System.Drawing.Point(121, 239);
            this.VkTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.VkTextBox.Name = "VkTextBox";
            this.VkTextBox.Size = new System.Drawing.Size(177, 22);
            this.VkTextBox.TabIndex = 11;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(343, 10);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(424, 10);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddPhotoPictureBox
            // 
            this.AddPhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.add_photo_32x32_gray;
            this.AddPhotoPictureBox.Location = new System.Drawing.Point(46, 118);
            this.AddPhotoPictureBox.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.AddPhotoPictureBox.Name = "AddPhotoPictureBox";
            this.AddPhotoPictureBox.Size = new System.Drawing.Size(32, 32);
            this.AddPhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddPhotoPictureBox.TabIndex = 13;
            this.AddPhotoPictureBox.TabStop = false;
            this.AddPhotoPictureBox.MouseEnter += new System.EventHandler(this.AddPhotoPictureBox_MouseEnter);
            this.AddPhotoPictureBox.MouseLeave += new System.EventHandler(this.AddPhotoPictureBox_MouseLeave);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 341);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ContactForm";
            this.ShowIcon = false;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContactPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddPhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox ContactPictureBox;
        private System.Windows.Forms.Label FulNamelabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label VkLabel;
        private System.Windows.Forms.TextBox VkTextBox;
        private System.Windows.Forms.DateTimePicker DateOfBirthTimePicker;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.PictureBox AddPhotoPictureBox;
    }
}