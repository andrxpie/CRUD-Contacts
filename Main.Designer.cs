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
            labelContactsCounter = new Label();
            labelWork = new Label();
            labelFamily = new Label();
            labelPrivate = new Label();
            labelFriends = new Label();
            labelWorkCounter = new Label();
            labelFamilyCounter = new Label();
            labelPrivateCounter = new Label();
            labelFriendsCounter = new Label();
            buttonExit = new Button();
            buttonDelete = new Button();
            buttonEdit = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            labelInfo = new Label();
            richTextBoxContacts = new RichTextBox();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // buttonAddNew
            // 
            buttonAddNew.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddNew.Location = new Point(12, 301);
            buttonAddNew.Name = "buttonAddNew";
            buttonAddNew.Size = new Size(163, 25);
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
            // labelContactsCounter
            // 
            labelContactsCounter.AutoSize = true;
            labelContactsCounter.BackColor = Color.MediumSlateBlue;
            labelContactsCounter.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelContactsCounter.Location = new Point(152, 9);
            labelContactsCounter.Name = "labelContactsCounter";
            labelContactsCounter.Size = new Size(13, 15);
            labelContactsCounter.TabIndex = 3;
            labelContactsCounter.Text = "0";
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
            // labelFriends
            // 
            labelFriends.AutoSize = true;
            labelFriends.BackColor = Color.Aqua;
            labelFriends.FlatStyle = FlatStyle.Flat;
            labelFriends.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFriends.Location = new Point(-5, 156);
            labelFriends.Name = "labelFriends";
            labelFriends.Size = new Size(175, 15);
            labelFriends.TabIndex = 4;
            labelFriends.Text = "    Friends                 ";
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
            // labelFriendsCounter
            // 
            labelFriendsCounter.AutoSize = true;
            labelFriendsCounter.BackColor = Color.Aqua;
            labelFriendsCounter.Font = new Font("Cascadia Mono SemiBold", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelFriendsCounter.Location = new Point(150, 156);
            labelFriendsCounter.Name = "labelFriendsCounter";
            labelFriendsCounter.Size = new Size(13, 15);
            labelFriendsCounter.TabIndex = 5;
            labelFriendsCounter.Text = "0";
            labelFriendsCounter.TextAlign = ContentAlignment.MiddleRight;
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
            buttonDelete.Size = new Size(163, 25);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEdit.Location = new Point(12, 332);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(163, 25);
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
            // textBox1
            // 
            textBox1.BackColor = Color.MediumPurple;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Cascadia Mono SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(12, 281);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 14);
            textBox1.TabIndex = 12;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(richTextBoxContacts);
            Controls.Add(labelInfo);
            Controls.Add(buttonEdit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonExit);
            Controls.Add(labelFriendsCounter);
            Controls.Add(labelPrivateCounter);
            Controls.Add(labelFamilyCounter);
            Controls.Add(labelWorkCounter);
            Controls.Add(labelFriends);
            Controls.Add(labelPrivate);
            Controls.Add(labelFamily);
            Controls.Add(labelWork);
            Controls.Add(labelContactsCounter);
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
        private Label labelContactsCounter;
        private Label labelWork;
        private Label labelFamily;
        private Label labelPrivate;
        private Label labelFriends;
        private Label labelWorkCounter;
        private Label labelFamilyCounter;
        private Label labelPrivateCounter;
        private Label labelFriendsCounter;
        private Button buttonExit;
        private Button buttonDelete;
        private Button buttonEdit;
        private ContextMenuStrip contextMenuStrip1;
        private Label labelInfo;
        private RichTextBox richTextBoxContacts;
        private TextBox textBox1;
    }
}