namespace CRUD___Contacts
{
    partial class Main
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
            buttonAddNew = new Button();
            labelAllContactsCounter = new Label();
            labelWork = new Label();
            labelFamily = new Label();
            labelPrivate = new Label();
            labelFriend = new Label();
            labelWorkCounter = new Label();
            labelFamilyCounter = new Label();
            labelPrivateCounter = new Label();
            labelFriendCounter = new Label();
            buttonExit = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            labelInfo = new Label();
            richTextBoxContacts = new RichTextBox();
            textBoxMatchName = new TextBox();
            richTextBoxOutput = new RichTextBox();
            buttonViewContact = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuOpen = new ToolStripMenuItem();
            toolStripMenuSave = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            labelIsFavorite = new Label();
            labelName = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelType = new Label();
            labelID = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddNew
            // 
            buttonAddNew.FlatAppearance.BorderColor = Color.White;
            buttonAddNew.FlatAppearance.MouseDownBackColor = Color.Transparent;
            buttonAddNew.FlatAppearance.MouseOverBackColor = Color.Transparent;
            buttonAddNew.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddNew.Location = new Point(12, 248);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(158, 25);
            buttonAddNew.TabIndex = 1;
            buttonAddNew.Text = "Add new";
            buttonAddNew.UseVisualStyleBackColor = true;
            buttonAddNew.Click += AddContact;
            // 
            // labelAllContactsCounter
            // 
            labelAllContactsCounter.AutoSize = true;
            labelAllContactsCounter.BackColor = Color.Aquamarine;
            labelAllContactsCounter.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAllContactsCounter.ForeColor = Color.Black;
            labelAllContactsCounter.Location = new Point(150, 37);
            labelAllContactsCounter.Name = "labelAllContactsCounter";
            labelAllContactsCounter.Size = new Size(16, 17);
            labelAllContactsCounter.TabIndex = 3;
            labelAllContactsCounter.Text = "0";
            // 
            // labelWork
            // 
            labelWork.AutoSize = true;
            labelWork.BackColor = Color.DarkSlateBlue;
            labelWork.FlatStyle = FlatStyle.Flat;
            labelWork.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelWork.ForeColor = Color.White;
            labelWork.Location = new Point(-5, 66);
            labelWork.Name = "labelWork";
            labelWork.Size = new Size(175, 15);
            labelWork.TabIndex = 4;
            labelWork.Text = "    Work                    ";
            // 
            // labelFamily
            // 
            labelFamily.AutoSize = true;
            labelFamily.BackColor = Color.DarkSlateBlue;
            labelFamily.FlatStyle = FlatStyle.Flat;
            labelFamily.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFamily.ForeColor = Color.White;
            labelFamily.Location = new Point(-5, 96);
            labelFamily.Name = "labelFamily";
            labelFamily.Size = new Size(175, 15);
            labelFamily.TabIndex = 4;
            labelFamily.Text = "    Family                  ";
            // 
            // labelPrivate
            // 
            labelPrivate.AutoSize = true;
            labelPrivate.BackColor = Color.DarkSlateBlue;
            labelPrivate.FlatStyle = FlatStyle.Flat;
            labelPrivate.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrivate.ForeColor = Color.White;
            labelPrivate.Location = new Point(-5, 126);
            labelPrivate.Name = "labelPrivate";
            labelPrivate.Size = new Size(175, 15);
            labelPrivate.TabIndex = 4;
            labelPrivate.Text = "    Private                 ";
            // 
            // labelFriend
            // 
            labelFriend.AutoSize = true;
            labelFriend.BackColor = Color.DarkSlateBlue;
            labelFriend.FlatStyle = FlatStyle.Flat;
            labelFriend.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFriend.ForeColor = Color.White;
            labelFriend.Location = new Point(-5, 156);
            labelFriend.Name = "labelFriend";
            labelFriend.Size = new Size(175, 15);
            labelFriend.TabIndex = 4;
            labelFriend.Text = "    Friends                 ";
            // 
            // labelWorkCounter
            // 
            labelWorkCounter.AutoSize = true;
            labelWorkCounter.BackColor = Color.Aquamarine;
            labelWorkCounter.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelWorkCounter.ForeColor = Color.Black;
            labelWorkCounter.Location = new Point(150, 66);
            labelWorkCounter.Name = "labelWorkCounter";
            labelWorkCounter.Size = new Size(13, 15);
            labelWorkCounter.TabIndex = 5;
            labelWorkCounter.Text = "0";
            labelWorkCounter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelFamilyCounter
            // 
            labelFamilyCounter.AutoSize = true;
            labelFamilyCounter.BackColor = Color.Aquamarine;
            labelFamilyCounter.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFamilyCounter.ForeColor = Color.Black;
            labelFamilyCounter.Location = new Point(150, 96);
            labelFamilyCounter.Name = "labelFamilyCounter";
            labelFamilyCounter.Size = new Size(13, 15);
            labelFamilyCounter.TabIndex = 5;
            labelFamilyCounter.Text = "0";
            labelFamilyCounter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelPrivateCounter
            // 
            labelPrivateCounter.AutoSize = true;
            labelPrivateCounter.BackColor = Color.Aquamarine;
            labelPrivateCounter.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrivateCounter.Location = new Point(150, 126);
            labelPrivateCounter.Name = "labelPrivateCounter";
            labelPrivateCounter.Size = new Size(13, 15);
            labelPrivateCounter.TabIndex = 5;
            labelPrivateCounter.Text = "0";
            labelPrivateCounter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelFriendCounter
            // 
            labelFriendCounter.AutoSize = true;
            labelFriendCounter.BackColor = Color.Aquamarine;
            labelFriendCounter.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFriendCounter.Location = new Point(150, 156);
            labelFriendCounter.Name = "labelFriendCounter";
            labelFriendCounter.Size = new Size(13, 15);
            labelFriendCounter.TabIndex = 5;
            labelFriendCounter.Text = "0";
            labelFriendCounter.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(12, 413);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 25);
            buttonExit.TabIndex = 9;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += Exit;
            // 
            // buttonDelete
            // 
            buttonDelete.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.Location = new Point(12, 363);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(158, 25);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += DeleteContact;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.Location = new Point(12, 332);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(158, 25);
            buttonEdit.TabIndex = 9;
            buttonEdit.Text = "Edit";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += EditContact;
            // 
            // labelInfo
            // 
            labelInfo.BackColor = Color.Aquamarine;
            labelInfo.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelInfo.Location = new Point(-5, 37);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(812, 17);
            labelInfo.TabIndex = 10;
            labelInfo.Text = "  All contacts";
            // 
            // richTextBoxContacts
            // 
            richTextBoxContacts.BackColor = Color.DarkSlateBlue;
            richTextBoxContacts.BorderStyle = BorderStyle.None;
            richTextBoxContacts.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxContacts.ForeColor = Color.White;
            richTextBoxContacts.Location = new Point(176, 66);
            richTextBoxContacts.Name = "richTextBoxContacts";
            richTextBoxContacts.ReadOnly = true;
            richTextBoxContacts.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxContacts.Size = new Size(619, 372);
            richTextBoxContacts.TabIndex = 11;
            richTextBoxContacts.Text = "";
            // 
            // textBoxMatchName
            // 
            textBoxMatchName.BackColor = Color.DarkSlateBlue;
            textBoxMatchName.BorderStyle = BorderStyle.None;
            textBoxMatchName.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMatchName.ForeColor = Color.White;
            textBoxMatchName.Location = new Point(12, 279);
            textBoxMatchName.Name = "textBoxMatchName";
            textBoxMatchName.Size = new Size(158, 16);
            textBoxMatchName.TabIndex = 12;
            textBoxMatchName.TextAlign = HorizontalAlignment.Center;
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.BackColor = Color.DarkSlateBlue;
            richTextBoxOutput.BorderStyle = BorderStyle.None;
            richTextBoxOutput.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxOutput.ForeColor = Color.White;
            richTextBoxOutput.Location = new Point(12, 183);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.ReadOnly = true;
            richTextBoxOutput.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxOutput.Size = new Size(158, 59);
            richTextBoxOutput.TabIndex = 13;
            richTextBoxOutput.Text = " Output:";
            // 
            // buttonViewContact
            // 
            buttonViewContact.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonViewContact.Location = new Point(12, 301);
            buttonViewContact.Name = "buttonViewContact";
            buttonViewContact.Size = new Size(158, 25);
            buttonViewContact.TabIndex = 9;
            buttonViewContact.Text = "View";
            buttonViewContact.UseVisualStyleBackColor = true;
            buttonViewContact.Click += ViewContact;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.BackColor = Color.Aquamarine;
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuOpen, toolStripMenuSave });
            fileToolStripMenuItem.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            fileToolStripMenuItem.ForeColor = Color.Black;
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(47, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuOpen
            // 
            toolStripMenuOpen.BackColor = Color.Aquamarine;
            toolStripMenuOpen.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuOpen.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuOpen.ForeColor = Color.Black;
            toolStripMenuOpen.Name = "toolStripMenuOpen";
            toolStripMenuOpen.Size = new Size(180, 22);
            toolStripMenuOpen.Text = "Open";
            toolStripMenuOpen.Click += OpenContacts;
            // 
            // toolStripMenuSave
            // 
            toolStripMenuSave.BackColor = Color.Aquamarine;
            toolStripMenuSave.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripMenuSave.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            toolStripMenuSave.ForeColor = Color.Black;
            toolStripMenuSave.Name = "toolStripMenuSave";
            toolStripMenuSave.Size = new Size(180, 22);
            toolStripMenuSave.Text = "Save";
            toolStripMenuSave.Click += SaveContacts;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // labelIsFavorite
            // 
            labelIsFavorite.AutoSize = true;
            labelIsFavorite.BackColor = Color.Aquamarine;
            labelIsFavorite.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelIsFavorite.Location = new Point(210, 37);
            labelIsFavorite.Name = "labelIsFavorite";
            labelIsFavorite.Size = new Size(32, 17);
            labelIsFavorite.TabIndex = 15;
            labelIsFavorite.Text = "▼/▽";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.Aquamarine;
            labelName.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(248, 37);
            labelName.Name = "labelName";
            labelName.Size = new Size(40, 17);
            labelName.TabIndex = 15;
            labelName.Text = "Name";
            // 
            // labelPhone
            // 
            labelPhone.AutoSize = true;
            labelPhone.BackColor = Color.Aquamarine;
            labelPhone.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhone.Location = new Point(396, 37);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(48, 17);
            labelPhone.TabIndex = 15;
            labelPhone.Text = "Phone";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.BackColor = Color.Aquamarine;
            labelEmail.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(536, 37);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(48, 17);
            labelEmail.TabIndex = 15;
            labelEmail.Text = "Email";
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.BackColor = Color.Aquamarine;
            labelType.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelType.Location = new Point(729, 37);
            labelType.Name = "labelType";
            labelType.Size = new Size(40, 17);
            labelType.TabIndex = 15;
            labelType.Text = "Type";
            // 
            // labelID
            // 
            labelID.AutoSize = true;
            labelID.BackColor = Color.Aquamarine;
            labelID.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelID.Location = new Point(180, 37);
            labelID.Name = "labelID";
            labelID.Size = new Size(24, 17);
            labelID.TabIndex = 15;
            labelID.Text = "Id";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(labelType);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelName);
            Controls.Add(labelID);
            Controls.Add(labelIsFavorite);
            Controls.Add(menuStrip1);
            Controls.Add(richTextBoxOutput);
            Controls.Add(textBoxMatchName);
            Controls.Add(richTextBoxContacts);
            Controls.Add(buttonViewContact);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonExit);
            Controls.Add(labelFriendCounter);
            Controls.Add(labelPrivateCounter);
            Controls.Add(labelFamilyCounter);
            Controls.Add(labelWorkCounter);
            Controls.Add(labelFriend);
            Controls.Add(labelPrivate);
            Controls.Add(labelFamily);
            Controls.Add(labelWork);
            Controls.Add(labelAllContactsCounter);
            Controls.Add(buttonAddNew);
            Controls.Add(labelInfo);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "Contacts";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAddNew;
        private Label labelAllContactsCounter;
        private Label labelWork;
        private Label labelFamily;
        private Label labelPrivate;
        private Label labelFriend;
        private Label labelWorkCounter;
        private Label labelFamilyCounter;
        private Label labelPrivateCounter;
        private Label labelFriendCounter;
        private Button buttonExit;
        private Button buttonDelete;
        private Button buttonEdit;
        private Label labelInfo;
        private RichTextBox richTextBoxContacts;
        private TextBox textBoxMatchName;
        private RichTextBox richTextBoxOutput;
        private Button buttonViewContact;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuOpen;
        private ToolStripMenuItem toolStripMenuSave;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label labelIsFavorite;
        private Label labelName;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelType;
        private Label labelID;
    }
}