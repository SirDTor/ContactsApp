namespace ContactsApp.View
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainContactsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ContactsPanel = new System.Windows.Forms.Panel();
            this.ContactsButtonTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.RemoveContactPictureBox = new System.Windows.Forms.PictureBox();
            this.AddContactPictureBox = new System.Windows.Forms.PictureBox();
            this.EditContactPictureBox = new System.Windows.Forms.PictureBox();
            this.AddRandomContactPictureBox = new System.Windows.Forms.PictureBox();
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.ContactsListBox = new System.Windows.Forms.ListBox();
            this.ContactsInfoPanel = new System.Windows.Forms.Panel();
            this.BirthdayPanel = new System.Windows.Forms.Panel();
            this.BirthdayPanelCloseButton = new System.Windows.Forms.Button();
            this.BirthdaySurnameLabel = new System.Windows.Forms.Label();
            this.BirthdayPanelLabel = new System.Windows.Forms.Label();
            this.BirhdayInfoPictureBox = new System.Windows.Forms.PictureBox();
            this.VkTextbox = new System.Windows.Forms.TextBox();
            this.VkLabel = new System.Windows.Forms.Label();
            this.DateOfBirthTextBox = new System.Windows.Forms.TextBox();
            this.DateOfBirthLabel = new System.Windows.Forms.Label();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.UpPanel = new System.Windows.Forms.Panel();
            this.UpPanelPictureBox = new System.Windows.Forms.PictureBox();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.MainContactsTableLayoutPanel.SuspendLayout();
            this.ContactsPanel.SuspendLayout();
            this.ContactsButtonTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRandomContactPictureBox)).BeginInit();
            this.ContactsInfoPanel.SuspendLayout();
            this.BirthdayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirhdayInfoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.UpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpPanelPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainContactsTableLayoutPanel
            // 
            this.MainContactsTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainContactsTableLayoutPanel.ColumnCount = 2;
            this.MainContactsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.MainContactsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainContactsTableLayoutPanel.Controls.Add(this.ContactsPanel, 0, 0);
            this.MainContactsTableLayoutPanel.Controls.Add(this.ContactsInfoPanel, 1, 0);
            this.MainContactsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainContactsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(6);
            this.MainContactsTableLayoutPanel.Name = "MainContactsTableLayoutPanel";
            this.MainContactsTableLayoutPanel.RowCount = 1;
            this.MainContactsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainContactsTableLayoutPanel.Size = new System.Drawing.Size(881, 554);
            this.MainContactsTableLayoutPanel.TabIndex = 0;
            // 
            // ContactsPanel
            // 
            this.ContactsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsPanel.Controls.Add(this.ContactsButtonTableLayoutPanel);
            this.ContactsPanel.Controls.Add(this.FindLabel);
            this.ContactsPanel.Controls.Add(this.FindTextBox);
            this.ContactsPanel.Controls.Add(this.ContactsListBox);
            this.ContactsPanel.Location = new System.Drawing.Point(4, 4);
            this.ContactsPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ContactsPanel.Name = "ContactsPanel";
            this.ContactsPanel.Size = new System.Drawing.Size(242, 546);
            this.ContactsPanel.TabIndex = 0;
            // 
            // ContactsButtonTableLayoutPanel
            // 
            this.ContactsButtonTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsButtonTableLayoutPanel.ColumnCount = 4;
            this.ContactsButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ContactsButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ContactsButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ContactsButtonTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ContactsButtonTableLayoutPanel.Controls.Add(this.RemoveContactPictureBox, 2, 0);
            this.ContactsButtonTableLayoutPanel.Controls.Add(this.AddContactPictureBox, 0, 0);
            this.ContactsButtonTableLayoutPanel.Controls.Add(this.EditContactPictureBox, 1, 0);
            this.ContactsButtonTableLayoutPanel.Controls.Add(this.AddRandomContactPictureBox, 3, 0);
            this.ContactsButtonTableLayoutPanel.Location = new System.Drawing.Point(0, 499);
            this.ContactsButtonTableLayoutPanel.Margin = new System.Windows.Forms.Padding(6);
            this.ContactsButtonTableLayoutPanel.Name = "ContactsButtonTableLayoutPanel";
            this.ContactsButtonTableLayoutPanel.RowCount = 1;
            this.ContactsButtonTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ContactsButtonTableLayoutPanel.Size = new System.Drawing.Size(238, 45);
            this.ContactsButtonTableLayoutPanel.TabIndex = 3;
            // 
            // RemoveContactPictureBox
            // 
            this.RemoveContactPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveContactPictureBox.Image = global::ContactsApp.View.Properties.Resources.remove_contact_32x32_gray;
            this.RemoveContactPictureBox.Location = new System.Drawing.Point(118, 0);
            this.RemoveContactPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveContactPictureBox.Name = "RemoveContactPictureBox";
            this.RemoveContactPictureBox.Size = new System.Drawing.Size(59, 45);
            this.RemoveContactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.RemoveContactPictureBox.TabIndex = 2;
            this.RemoveContactPictureBox.TabStop = false;
            this.RemoveContactPictureBox.Click += new System.EventHandler(this.RemoveContactPictureBox_Click);
            this.RemoveContactPictureBox.MouseEnter += new System.EventHandler(this.RemoveContactPictureBox_MouseEnter);
            this.RemoveContactPictureBox.MouseLeave += new System.EventHandler(this.RemoveContactPictureBox_MouseLeave);
            // 
            // AddContactPictureBox
            // 
            this.AddContactPictureBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AddContactPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddContactPictureBox.Image = global::ContactsApp.View.Properties.Resources.add_contact_32x32_gray;
            this.AddContactPictureBox.Location = new System.Drawing.Point(0, 0);
            this.AddContactPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.AddContactPictureBox.Name = "AddContactPictureBox";
            this.AddContactPictureBox.Size = new System.Drawing.Size(59, 45);
            this.AddContactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddContactPictureBox.TabIndex = 0;
            this.AddContactPictureBox.TabStop = false;
            this.AddContactPictureBox.Click += new System.EventHandler(this.AddContactPictureBox_Click);
            this.AddContactPictureBox.MouseEnter += new System.EventHandler(this.AddContactPictureBox_MouseEnter);
            this.AddContactPictureBox.MouseLeave += new System.EventHandler(this.AddContactPictureBox_MouseLeave);
            // 
            // EditContactPictureBox
            // 
            this.EditContactPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditContactPictureBox.Image = global::ContactsApp.View.Properties.Resources.edit_contact_32x32_gray;
            this.EditContactPictureBox.Location = new System.Drawing.Point(59, 0);
            this.EditContactPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.EditContactPictureBox.Name = "EditContactPictureBox";
            this.EditContactPictureBox.Size = new System.Drawing.Size(59, 45);
            this.EditContactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.EditContactPictureBox.TabIndex = 1;
            this.EditContactPictureBox.TabStop = false;
            this.EditContactPictureBox.Click += new System.EventHandler(this.EditContactPictureBox_Click);
            this.EditContactPictureBox.MouseEnter += new System.EventHandler(this.EditContactPictureBox_MouseEnter);
            this.EditContactPictureBox.MouseLeave += new System.EventHandler(this.EditContactPictureBox_MouseLeave);
            // 
            // AddRandomContactPictureBox
            // 
            this.AddRandomContactPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddRandomContactPictureBox.Image = global::ContactsApp.View.Properties.Resources.add_random_contact_32x32_gray;
            this.AddRandomContactPictureBox.Location = new System.Drawing.Point(177, 0);
            this.AddRandomContactPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.AddRandomContactPictureBox.Name = "AddRandomContactPictureBox";
            this.AddRandomContactPictureBox.Size = new System.Drawing.Size(61, 45);
            this.AddRandomContactPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.AddRandomContactPictureBox.TabIndex = 3;
            this.AddRandomContactPictureBox.TabStop = false;
            this.AddRandomContactPictureBox.Click += new System.EventHandler(this.AddRandomContactPictureBox_Click);
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindLabel.Location = new System.Drawing.Point(4, 3);
            this.FindLabel.Margin = new System.Windows.Forms.Padding(6);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(43, 21);
            this.FindLabel.TabIndex = 1;
            this.FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(59, 4);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(179, 20);
            this.FindTextBox.TabIndex = 0;
            // 
            // ContactsListBox
            // 
            this.ContactsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsListBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsListBox.FormattingEnabled = true;
            this.ContactsListBox.IntegralHeight = false;
            this.ContactsListBox.Items.AddRange(new object[] {
            "Алексеев Егор",
            "Барсукова Карина",
            "Белоусова Майя",
            "Беляева Екатерина",
            "Богданов Роман",
            "Бондарев Иван",
            "Борисов Дмитрий",
            "Бычков Алексей",
            "Вдовин Константин",
            "Владимирова Алиса ",
            "Волошин Артём ",
            "Герасимова Полина ",
            "Герасимова София ",
            "Гончаров Максим ",
            "Григорьева Василиса ",
            "Гуляев Егор ",
            "Данилов Богдан ",
            "Денисов Андрей ",
            "Дмитриев Роман ",
            "Дорофеев Степан ",
            "Евдокимова Алиса ",
            "Евдокимова Мария ",
            "Егоров Игорь ",
            "Ежов Георгий ",
            "Ермакова Вероника ",
            "Ефимова София ",
            "Жуков Артём ",
            "Зайцев Тимур ",
            "Захаров Платон ",
            "Иванова Алиса ",
            "Иванова София ",
            "Игнатов Тимофей "});
            this.ContactsListBox.Location = new System.Drawing.Point(0, 36);
            this.ContactsListBox.Margin = new System.Windows.Forms.Padding(6);
            this.ContactsListBox.Name = "ContactsListBox";
            this.ContactsListBox.Size = new System.Drawing.Size(238, 463);
            this.ContactsListBox.TabIndex = 2;
            this.ContactsListBox.SelectedIndexChanged += new System.EventHandler(this.ContactsListBox_SelectedIndexChanged);
            // 
            // ContactsInfoPanel
            // 
            this.ContactsInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactsInfoPanel.Controls.Add(this.BirthdayPanel);
            this.ContactsInfoPanel.Controls.Add(this.VkTextbox);
            this.ContactsInfoPanel.Controls.Add(this.VkLabel);
            this.ContactsInfoPanel.Controls.Add(this.DateOfBirthTextBox);
            this.ContactsInfoPanel.Controls.Add(this.DateOfBirthLabel);
            this.ContactsInfoPanel.Controls.Add(this.PhoneNumberTextBox);
            this.ContactsInfoPanel.Controls.Add(this.PhoneNumberLabel);
            this.ContactsInfoPanel.Controls.Add(this.EmailTextBox);
            this.ContactsInfoPanel.Controls.Add(this.EmailLabel);
            this.ContactsInfoPanel.Controls.Add(this.FullNameTextBox);
            this.ContactsInfoPanel.Controls.Add(this.FullNameLabel);
            this.ContactsInfoPanel.Controls.Add(this.PhotoPictureBox);
            this.ContactsInfoPanel.Controls.Add(this.UpPanel);
            this.ContactsInfoPanel.Location = new System.Drawing.Point(253, 3);
            this.ContactsInfoPanel.Name = "ContactsInfoPanel";
            this.ContactsInfoPanel.Size = new System.Drawing.Size(625, 548);
            this.ContactsInfoPanel.TabIndex = 1;
            // 
            // BirthdayPanel
            // 
            this.BirthdayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.BirthdayPanel.Controls.Add(this.BirthdayPanelCloseButton);
            this.BirthdayPanel.Controls.Add(this.BirthdaySurnameLabel);
            this.BirthdayPanel.Controls.Add(this.BirthdayPanelLabel);
            this.BirthdayPanel.Controls.Add(this.BirhdayInfoPictureBox);
            this.BirthdayPanel.Location = new System.Drawing.Point(-2, 466);
            this.BirthdayPanel.Name = "BirthdayPanel";
            this.BirthdayPanel.Size = new System.Drawing.Size(627, 79);
            this.BirthdayPanel.TabIndex = 11;
            // 
            // BirthdayPanelCloseButton
            // 
            this.BirthdayPanelCloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BirthdayPanelCloseButton.FlatAppearance.BorderSize = 0;
            this.BirthdayPanelCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BirthdayPanelCloseButton.Image = global::ContactsApp.View.Properties.Resources.close_32x32;
            this.BirthdayPanelCloseButton.Location = new System.Drawing.Point(589, 6);
            this.BirthdayPanelCloseButton.Margin = new System.Windows.Forms.Padding(6);
            this.BirthdayPanelCloseButton.Name = "BirthdayPanelCloseButton";
            this.BirthdayPanelCloseButton.Size = new System.Drawing.Size(32, 32);
            this.BirthdayPanelCloseButton.TabIndex = 3;
            this.BirthdayPanelCloseButton.UseVisualStyleBackColor = true;
            this.BirthdayPanelCloseButton.Click += new System.EventHandler(this.BirthdayPanelCloseButton_Click);
            // 
            // BirthdaySurnameLabel
            // 
            this.BirthdaySurnameLabel.AutoSize = true;
            this.BirthdaySurnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdaySurnameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdaySurnameLabel.Location = new System.Drawing.Point(85, 40);
            this.BirthdaySurnameLabel.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.BirthdaySurnameLabel.Name = "BirthdaySurnameLabel";
            this.BirthdaySurnameLabel.Size = new System.Drawing.Size(201, 13);
            this.BirthdaySurnameLabel.TabIndex = 2;
            this.BirthdaySurnameLabel.Text = "Абакумов, Петров, Иванов и др.";
            // 
            // BirthdayPanelLabel
            // 
            this.BirthdayPanelLabel.AutoSize = true;
            this.BirthdayPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthdayPanelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(144)))), ((int)(((byte)(255)))));
            this.BirthdayPanelLabel.Location = new System.Drawing.Point(85, 21);
            this.BirthdayPanelLabel.Name = "BirthdayPanelLabel";
            this.BirthdayPanelLabel.Size = new System.Drawing.Size(124, 13);
            this.BirthdayPanelLabel.TabIndex = 1;
            this.BirthdayPanelLabel.Text = "Today is Birthday of:";
            // 
            // BirhdayInfoPictureBox
            // 
            this.BirhdayInfoPictureBox.Image = global::ContactsApp.View.Properties.Resources.info_48x48;
            this.BirhdayInfoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.BirhdayInfoPictureBox.Name = "BirhdayInfoPictureBox";
            this.BirhdayInfoPictureBox.Size = new System.Drawing.Size(76, 73);
            this.BirhdayInfoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.BirhdayInfoPictureBox.TabIndex = 0;
            this.BirhdayInfoPictureBox.TabStop = false;
            // 
            // VkTextbox
            // 
            this.VkTextbox.Location = new System.Drawing.Point(109, 256);
            this.VkTextbox.Name = "VkTextbox";
            this.VkTextbox.Size = new System.Drawing.Size(205, 20);
            this.VkTextbox.TabIndex = 10;
            this.VkTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.VkTextbox_KeyPress);
            // 
            // VkLabel
            // 
            this.VkLabel.AutoSize = true;
            this.VkLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VkLabel.Location = new System.Drawing.Point(109, 232);
            this.VkLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.VkLabel.Name = "VkLabel";
            this.VkLabel.Size = new System.Drawing.Size(32, 21);
            this.VkLabel.TabIndex = 9;
            this.VkLabel.Text = "VK:";
            // 
            // DateOfBirthTextBox
            // 
            this.DateOfBirthTextBox.Location = new System.Drawing.Point(109, 199);
            this.DateOfBirthTextBox.Name = "DateOfBirthTextBox";
            this.DateOfBirthTextBox.Size = new System.Drawing.Size(205, 20);
            this.DateOfBirthTextBox.TabIndex = 8;
            this.DateOfBirthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateOfBirthTextBox_KeyPress);
            // 
            // DateOfBirthLabel
            // 
            this.DateOfBirthLabel.AutoSize = true;
            this.DateOfBirthLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateOfBirthLabel.Location = new System.Drawing.Point(109, 175);
            this.DateOfBirthLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.DateOfBirthLabel.Name = "DateOfBirthLabel";
            this.DateOfBirthLabel.Size = new System.Drawing.Size(100, 21);
            this.DateOfBirthLabel.TabIndex = 7;
            this.DateOfBirthLabel.Text = "Date of Birth:";
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(109, 142);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(205, 20);
            this.PhoneNumberTextBox.TabIndex = 6;
            this.PhoneNumberTextBox.Text = "+7 (923) 111-33-21";
            this.PhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PhoneNumberTextBox_KeyPress);
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(109, 118);
            this.PhoneNumberLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(119, 21);
            this.PhoneNumberLabel.TabIndex = 5;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailTextBox.Location = new System.Drawing.Point(109, 83);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(507, 20);
            this.EmailTextBox.TabIndex = 4;
            this.EmailTextBox.Text = "abakumov@no.mail";
            this.EmailTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EmailTextBox_KeyPress);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(109, 62);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(57, 21);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(109, 29);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(507, 20);
            this.FullNameTextBox.TabIndex = 2;
            this.FullNameTextBox.Text = "Абакумов Дмитрий Николаевич";
            this.FullNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FullNameTextBox_KeyPress);
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullNameLabel.Location = new System.Drawing.Point(109, 5);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(84, 21);
            this.FullNameLabel.TabIndex = 1;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.Image = global::ContactsApp.View.Properties.Resources.photo_placeholder_100x100;
            this.PhotoPictureBox.Location = new System.Drawing.Point(3, 5);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(100, 100);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PhotoPictureBox.TabIndex = 0;
            this.PhotoPictureBox.TabStop = false;
            // 
            // UpPanel
            // 
            this.UpPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpPanel.Controls.Add(this.UpPanelPictureBox);
            this.UpPanel.Location = new System.Drawing.Point(573, 493);
            this.UpPanel.Margin = new System.Windows.Forms.Padding(0);
            this.UpPanel.Name = "UpPanel";
            this.UpPanel.Size = new System.Drawing.Size(52, 52);
            this.UpPanel.TabIndex = 13;
            this.UpPanel.Visible = false;
            // 
            // UpPanelPictureBox
            // 
            this.UpPanelPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.UpPanelPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.UpPanelPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UpPanelPictureBox.Image")));
            this.UpPanelPictureBox.Location = new System.Drawing.Point(2, 2);
            this.UpPanelPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.UpPanelPictureBox.Name = "UpPanelPictureBox";
            this.UpPanelPictureBox.Size = new System.Drawing.Size(48, 48);
            this.UpPanelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.UpPanelPictureBox.TabIndex = 12;
            this.UpPanelPictureBox.TabStop = false;
            this.UpPanelPictureBox.Click += new System.EventHandler(this.PanelUpPictureBox_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(881, 554);
            this.Controls.Add(this.MainContactsTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ContactsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            this.MainContactsTableLayoutPanel.ResumeLayout(false);
            this.ContactsPanel.ResumeLayout(false);
            this.ContactsPanel.PerformLayout();
            this.ContactsButtonTableLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RemoveContactPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddContactPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditContactPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddRandomContactPictureBox)).EndInit();
            this.ContactsInfoPanel.ResumeLayout(false);
            this.ContactsInfoPanel.PerformLayout();
            this.BirthdayPanel.ResumeLayout(false);
            this.BirthdayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BirhdayInfoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.UpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpPanelPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MainContactsTableLayoutPanel;
        private System.Windows.Forms.Panel ContactsPanel;
        private System.Windows.Forms.TableLayoutPanel ContactsButtonTableLayoutPanel;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.ListBox ContactsListBox;
        private System.Windows.Forms.PictureBox EditContactPictureBox;
        private System.Windows.Forms.PictureBox RemoveContactPictureBox;
        private System.Windows.Forms.Panel ContactsInfoPanel;
        private System.Windows.Forms.PictureBox PhotoPictureBox;
        private System.Windows.Forms.TextBox VkTextbox;
        private System.Windows.Forms.Label VkLabel;
        private System.Windows.Forms.TextBox DateOfBirthTextBox;
        private System.Windows.Forms.Label DateOfBirthLabel;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.PictureBox AddContactPictureBox;
        private System.Windows.Forms.Panel BirthdayPanel;
        private System.Windows.Forms.Label BirthdaySurnameLabel;
        private System.Windows.Forms.Label BirthdayPanelLabel;
        private System.Windows.Forms.PictureBox BirhdayInfoPictureBox;
        private System.Windows.Forms.Button BirthdayPanelCloseButton;
        private System.Windows.Forms.PictureBox UpPanelPictureBox;
        private System.Windows.Forms.Panel UpPanel;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.PictureBox AddRandomContactPictureBox;
    }
}

