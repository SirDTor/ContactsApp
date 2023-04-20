namespace ContactsApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.TableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.CommonPanel = new System.Windows.Forms.Panel();
            this.IconLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.LicenceTextBox = new System.Windows.Forms.TextBox();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.OkAboutButton = new System.Windows.Forms.Button();
            this.MyEmailLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.GitLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ContactsAppLabel = new System.Windows.Forms.Label();
            this.TableLayoutPanel1.SuspendLayout();
            this.CommonPanel.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TableLayoutPanel1
            // 
            this.TableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.TableLayoutPanel1.ColumnCount = 1;
            this.TableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Controls.Add(this.CommonPanel, 0, 0);
            this.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.TableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.TableLayoutPanel1.Name = "TableLayoutPanel1";
            this.TableLayoutPanel1.RowCount = 1;
            this.TableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TableLayoutPanel1.Size = new System.Drawing.Size(553, 401);
            this.TableLayoutPanel1.TabIndex = 0;
            // 
            // CommonPanel
            // 
            this.CommonPanel.BackColor = System.Drawing.Color.White;
            this.CommonPanel.Controls.Add(this.IconLinkLabel);
            this.CommonPanel.Controls.Add(this.GitLinkLabel);
            this.CommonPanel.Controls.Add(this.LicenceTextBox);
            this.CommonPanel.Controls.Add(this.AboutPanel);
            this.CommonPanel.Controls.Add(this.MyEmailLabel);
            this.CommonPanel.Controls.Add(this.NameLabel);
            this.CommonPanel.Controls.Add(this.SourceLabel);
            this.CommonPanel.Controls.Add(this.GitLabel);
            this.CommonPanel.Controls.Add(this.EmailLabel);
            this.CommonPanel.Controls.Add(this.AuthorLabel);
            this.CommonPanel.Controls.Add(this.VersionLabel);
            this.CommonPanel.Controls.Add(this.ContactsAppLabel);
            this.CommonPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CommonPanel.Location = new System.Drawing.Point(0, 0);
            this.CommonPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CommonPanel.Name = "CommonPanel";
            this.CommonPanel.Size = new System.Drawing.Size(553, 401);
            this.CommonPanel.TabIndex = 0;
            // 
            // IconLinkLabel
            // 
            this.IconLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.IconLinkLabel.AutoSize = true;
            this.IconLinkLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IconLinkLabel.LinkVisited = true;
            this.IconLinkLabel.Location = new System.Drawing.Point(210, 328);
            this.IconLinkLabel.Margin = new System.Windows.Forms.Padding(1);
            this.IconLinkLabel.Name = "IconLinkLabel";
            this.IconLinkLabel.Size = new System.Drawing.Size(64, 13);
            this.IconLinkLabel.TabIndex = 12;
            this.IconLinkLabel.TabStop = true;
            this.IconLinkLabel.Text = "icons8.com";
            this.IconLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.iconLinkLabel_LinkClicked);
            // 
            // GitLinkLabel
            // 
            this.GitLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.GitLinkLabel.AutoSize = true;
            this.GitLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitLinkLabel.LinkVisited = true;
            this.GitLinkLabel.Location = new System.Drawing.Point(126, 149);
            this.GitLinkLabel.Name = "GitLinkLabel";
            this.GitLinkLabel.Size = new System.Drawing.Size(162, 17);
            this.GitLinkLabel.TabIndex = 11;
            this.GitLinkLabel.TabStop = true;
            this.GitLinkLabel.Text = "https://github.com/SirDTor";
            this.GitLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gitLinkLabel_LinkClicked);
            // 
            // LicenceTextBox
            // 
            this.LicenceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenceTextBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LicenceTextBox.Location = new System.Drawing.Point(12, 184);
            this.LicenceTextBox.Margin = new System.Windows.Forms.Padding(12, 18, 12, 3);
            this.LicenceTextBox.Multiline = true;
            this.LicenceTextBox.Name = "LicenceTextBox";
            this.LicenceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LicenceTextBox.Size = new System.Drawing.Size(529, 140);
            this.LicenceTextBox.TabIndex = 10;
            this.LicenceTextBox.Text = resources.GetString("LicenceTextBox.Text");
            this.LicenceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.licenceTextBox_KeyPress);
            // 
            // AboutPanel
            // 
            this.AboutPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AboutPanel.Controls.Add(this.OkAboutButton);
            this.AboutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AboutPanel.Location = new System.Drawing.Point(0, 356);
            this.AboutPanel.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(553, 45);
            this.AboutPanel.TabIndex = 9;
            // 
            // OkAboutButton
            // 
            this.OkAboutButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OkAboutButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OkAboutButton.Location = new System.Drawing.Point(466, 12);
            this.OkAboutButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.OkAboutButton.Name = "OkAboutButton";
            this.OkAboutButton.Size = new System.Drawing.Size(75, 23);
            this.OkAboutButton.TabIndex = 0;
            this.OkAboutButton.Text = "OK";
            this.OkAboutButton.UseVisualStyleBackColor = true;
            this.OkAboutButton.Click += new System.EventHandler(this.OkAboutButton_Click);
            // 
            // MyEmailLabel
            // 
            this.MyEmailLabel.AutoSize = true;
            this.MyEmailLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MyEmailLabel.Location = new System.Drawing.Point(126, 126);
            this.MyEmailLabel.Margin = new System.Windows.Forms.Padding(70, 0, 3, 0);
            this.MyEmailLabel.Name = "MyEmailLabel";
            this.MyEmailLabel.Size = new System.Drawing.Size(171, 17);
            this.MyEmailLabel.TabIndex = 8;
            this.MyEmailLabel.Text = "daniil.zorin.leon@gmail.com";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(126, 103);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(70, 0, 3, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 17);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Zorin Daniil";
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SourceLabel.Location = new System.Drawing.Point(13, 328);
            this.SourceLabel.Margin = new System.Windows.Forms.Padding(12, 0, 0, 15);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(202, 13);
            this.SourceLabel.TabIndex = 5;
            this.SourceLabel.Text = "All used images are downloaded from";
            this.SourceLabel.Click += new System.EventHandler(this.label6_Click);
            // 
            // GitLabel
            // 
            this.GitLabel.AutoSize = true;
            this.GitLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitLabel.Location = new System.Drawing.Point(12, 149);
            this.GitLabel.Margin = new System.Windows.Forms.Padding(12, 10, 3, 0);
            this.GitLabel.Name = "GitLabel";
            this.GitLabel.Size = new System.Drawing.Size(49, 17);
            this.GitLabel.TabIndex = 4;
            this.GitLabel.Text = "Github:";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(12, 126);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(12, 10, 3, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(47, 17);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "E-mail:";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthorLabel.Location = new System.Drawing.Point(12, 103);
            this.AuthorLabel.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(50, 17);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author:";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VersionLabel.Location = new System.Drawing.Point(13, 67);
            this.VersionLabel.Margin = new System.Windows.Forms.Padding(12, 6, 3, 0);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(31, 17);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v1.0";
            // 
            // ContactsAppLabel
            // 
            this.ContactsAppLabel.AutoSize = true;
            this.ContactsAppLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsAppLabel.Location = new System.Drawing.Point(9, 35);
            this.ContactsAppLabel.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.ContactsAppLabel.Name = "ContactsAppLabel";
            this.ContactsAppLabel.Size = new System.Drawing.Size(160, 32);
            this.ContactsAppLabel.TabIndex = 0;
            this.ContactsAppLabel.Text = "ContactsApp";
            // 
            // AboutForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(553, 401);
            this.Controls.Add(this.TableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.TableLayoutPanel1.ResumeLayout(false);
            this.CommonPanel.ResumeLayout(false);
            this.CommonPanel.PerformLayout();
            this.AboutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TableLayoutPanel1;
        private System.Windows.Forms.Panel CommonPanel;
        private System.Windows.Forms.Label ContactsAppLabel;
        private System.Windows.Forms.Label MyEmailLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label GitLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.TextBox LicenceTextBox;
        private System.Windows.Forms.Button OkAboutButton;
        private System.Windows.Forms.LinkLabel GitLinkLabel;
        private System.Windows.Forms.LinkLabel IconLinkLabel;
    }
}