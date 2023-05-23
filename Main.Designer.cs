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
            components = new System.ComponentModel.Container();
            buttonAddNew = new Button();
            labelAllContacts = new Label();
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            labelInfo = new Label();
            richTextBoxContacts = new RichTextBox();
            textBoxMatchName = new TextBox();
            richTextBoxOutput = new RichTextBox();
            buttonViewContact = new Button();
            SuspendLayout();
            // 
            // buttonAddNew
            // 
            buttonAddNew.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddNew.Location = new Point(12, 248);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(158, 25);
            buttonAddNew.TabIndex = 1;
            buttonAddNew.Text = "Add new";
            buttonAddNew.UseVisualStyleBackColor = true;
            buttonAddNew.Click += AddContact;
            // 
            // labelAllContacts
            // 
            labelAllContacts.BackColor = Color.MediumSlateBlue;
            labelAllContacts.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAllContacts.Location = new Point(-6, 9);
            labelAllContacts.Name = "labelAllContacts";
            labelAllContacts.Size = new Size(813, 15);
            labelAllContacts.TabIndex = 2;
            labelAllContacts.Text = "       All contacts                                                                                                                  ";
            labelAllContacts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAllContactsCounter
            // 
            labelAllContactsCounter.AutoSize = true;
            labelAllContactsCounter.BackColor = Color.MediumSlateBlue;
            labelAllContactsCounter.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAllContactsCounter.Location = new Point(152, 9);
            labelAllContactsCounter.Name = "labelAllContactsCounter";
            labelAllContactsCounter.Size = new Size(13, 15);
            labelAllContactsCounter.TabIndex = 3;
            labelAllContactsCounter.Text = "0";
            // 
            // labelWork
            // 
            labelWork.AutoSize = true;
            labelWork.BackColor = Color.Aquamarine;
            labelWork.FlatStyle = FlatStyle.Flat;
            labelWork.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelWork.Location = new Point(-5, 66);
            labelWork.Name = "labelWork";
            labelWork.Size = new Size(175, 15);
            labelWork.TabIndex = 4;
            labelWork.Text = "    Work                    ";
            // 
            // labelFamily
            // 
            labelFamily.AutoSize = true;
            labelFamily.BackColor = Color.MediumSlateBlue;
            labelFamily.FlatStyle = FlatStyle.Flat;
            labelFamily.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFamily.Location = new Point(-5, 96);
            labelFamily.Name = "labelFamily";
            labelFamily.Size = new Size(175, 15);
            labelFamily.TabIndex = 4;
            labelFamily.Text = "    Family                  ";
            // 
            // labelPrivate
            // 
            labelPrivate.AutoSize = true;
            labelPrivate.BackColor = Color.Orchid;
            labelPrivate.FlatStyle = FlatStyle.Flat;
            labelPrivate.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrivate.Location = new Point(-5, 126);
            labelPrivate.Name = "labelPrivate";
            labelPrivate.Size = new Size(175, 15);
            labelPrivate.TabIndex = 4;
            labelPrivate.Text = "    Private                 ";
            // 
            // labelFriend
            // 
            labelFriend.AutoSize = true;
            labelFriend.BackColor = Color.Aqua;
            labelFriend.FlatStyle = FlatStyle.Flat;
            labelFriend.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
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
            labelFamilyCounter.BackColor = Color.MediumSlateBlue;
            labelFamilyCounter.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
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
            labelPrivateCounter.BackColor = Color.Orchid;
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
            labelFriendCounter.BackColor = Color.Aqua;
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
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // labelInfo
            // 
            labelInfo.BackColor = Color.Aquamarine;
            labelInfo.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelInfo.Location = new Point(-5, 37);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(812, 17);
            labelInfo.TabIndex = 10;
            labelInfo.Text = "                              ▼    Name              Phone            Email                 Type";
            // 
            // richTextBoxContacts
            // 
            richTextBoxContacts.BackColor = Color.Gainsboro;
            richTextBoxContacts.BorderStyle = BorderStyle.None;
            richTextBoxContacts.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxContacts.Location = new Point(224, 66);
            richTextBoxContacts.Name = "richTextBoxContacts";
            richTextBoxContacts.ReadOnly = true;
            richTextBoxContacts.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxContacts.Size = new Size(571, 372);
            richTextBoxContacts.TabIndex = 11;
            richTextBoxContacts.Text = "";
            // 
            // textBoxMatchName
            // 
            textBoxMatchName.BackColor = Color.MediumPurple;
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
            richTextBoxOutput.BackColor = Color.MediumPurple;
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
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBoxOutput);
            Controls.Add(textBoxMatchName);
            Controls.Add(richTextBoxContacts);
            Controls.Add(labelInfo);
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
            Controls.Add(labelAllContacts);
            Controls.Add(buttonAddNew);
            Name = "Main";
            Text = "Contacts";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonAddNew;
        private Label labelAllContacts;
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
        private ContextMenuStrip contextMenuStrip1;
        private Label labelInfo;
        private RichTextBox richTextBoxContacts;
        private TextBox textBoxMatchName;
        private RichTextBox richTextBoxOutput;
        private Button buttonViewContact;
    }
}