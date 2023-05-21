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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.labelAllContacts = new System.Windows.Forms.Label();
            this.labelContactsCounter = new System.Windows.Forms.Label();
            this.labelWork = new System.Windows.Forms.Label();
            this.labelFamily = new System.Windows.Forms.Label();
            this.labelPrivate = new System.Windows.Forms.Label();
            this.labelFriends = new System.Windows.Forms.Label();
            this.labelWorkCounter = new System.Windows.Forms.Label();
            this.labelFamilyCounter = new System.Windows.Forms.Label();
            this.labelPrivateCounter = new System.Windows.Forms.Label();
            this.labelFriendsCounter = new System.Windows.Forms.Label();
            this.listViewContactList = new System.Windows.Forms.ListView();
            this.columnFavorite = new System.Windows.Forms.ColumnHeader();
            this.columnName = new System.Windows.Forms.ColumnHeader();
            this.columnPhone = new System.Windows.Forms.ColumnHeader();
            this.columnEmail = new System.Windows.Forms.ColumnHeader();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonFavourite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonAddNew.Location = new System.Drawing.Point(12, 270);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(163, 25);
            this.buttonAddNew.TabIndex = 1;
            this.buttonAddNew.Text = "Add new";
            this.buttonAddNew.UseVisualStyleBackColor = true;
            // 
            // labelAllContacts
            // 
            this.labelAllContacts.AutoSize = true;
            this.labelAllContacts.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelAllContacts.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAllContacts.Location = new System.Drawing.Point(-6, 9);
            this.labelAllContacts.Name = "labelAllContacts";
            this.labelAllContacts.Size = new System.Drawing.Size(805, 15);
            this.labelAllContacts.TabIndex = 2;
            this.labelAllContacts.Text = "       All contacts                                                              " +
    "                                                    ";
            this.labelAllContacts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelContactsCounter
            // 
            this.labelContactsCounter.AutoSize = true;
            this.labelContactsCounter.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelContactsCounter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelContactsCounter.Location = new System.Drawing.Point(152, 9);
            this.labelContactsCounter.Name = "labelContactsCounter";
            this.labelContactsCounter.Size = new System.Drawing.Size(13, 15);
            this.labelContactsCounter.TabIndex = 3;
            this.labelContactsCounter.Text = "0";
            // 
            // labelWork
            // 
            this.labelWork.AutoSize = true;
            this.labelWork.BackColor = System.Drawing.Color.Aquamarine;
            this.labelWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWork.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWork.Location = new System.Drawing.Point(-5, 66);
            this.labelWork.Name = "labelWork";
            this.labelWork.Size = new System.Drawing.Size(175, 15);
            this.labelWork.TabIndex = 4;
            this.labelWork.Text = "    Work                    ";
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelFamily.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFamily.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFamily.Location = new System.Drawing.Point(-5, 96);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(175, 15);
            this.labelFamily.TabIndex = 4;
            this.labelFamily.Text = "    Family                  ";
            // 
            // labelPrivate
            // 
            this.labelPrivate.AutoSize = true;
            this.labelPrivate.BackColor = System.Drawing.Color.Orchid;
            this.labelPrivate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPrivate.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrivate.Location = new System.Drawing.Point(-5, 126);
            this.labelPrivate.Name = "labelPrivate";
            this.labelPrivate.Size = new System.Drawing.Size(175, 15);
            this.labelPrivate.TabIndex = 4;
            this.labelPrivate.Text = "    Private                 ";
            // 
            // labelFriends
            // 
            this.labelFriends.AutoSize = true;
            this.labelFriends.BackColor = System.Drawing.Color.Aqua;
            this.labelFriends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFriends.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFriends.Location = new System.Drawing.Point(-5, 156);
            this.labelFriends.Name = "labelFriends";
            this.labelFriends.Size = new System.Drawing.Size(175, 15);
            this.labelFriends.TabIndex = 4;
            this.labelFriends.Text = "    Friends                 ";
            // 
            // labelWorkCounter
            // 
            this.labelWorkCounter.AutoSize = true;
            this.labelWorkCounter.BackColor = System.Drawing.Color.Aquamarine;
            this.labelWorkCounter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelWorkCounter.Location = new System.Drawing.Point(150, 66);
            this.labelWorkCounter.Name = "labelWorkCounter";
            this.labelWorkCounter.Size = new System.Drawing.Size(13, 15);
            this.labelWorkCounter.TabIndex = 5;
            this.labelWorkCounter.Text = "0";
            this.labelWorkCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFamilyCounter
            // 
            this.labelFamilyCounter.AutoSize = true;
            this.labelFamilyCounter.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.labelFamilyCounter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFamilyCounter.Location = new System.Drawing.Point(150, 96);
            this.labelFamilyCounter.Name = "labelFamilyCounter";
            this.labelFamilyCounter.Size = new System.Drawing.Size(13, 15);
            this.labelFamilyCounter.TabIndex = 5;
            this.labelFamilyCounter.Text = "0";
            this.labelFamilyCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrivateCounter
            // 
            this.labelPrivateCounter.AutoSize = true;
            this.labelPrivateCounter.BackColor = System.Drawing.Color.Orchid;
            this.labelPrivateCounter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPrivateCounter.Location = new System.Drawing.Point(150, 126);
            this.labelPrivateCounter.Name = "labelPrivateCounter";
            this.labelPrivateCounter.Size = new System.Drawing.Size(13, 15);
            this.labelPrivateCounter.TabIndex = 5;
            this.labelPrivateCounter.Text = "0";
            this.labelPrivateCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFriendsCounter
            // 
            this.labelFriendsCounter.AutoSize = true;
            this.labelFriendsCounter.BackColor = System.Drawing.Color.Aqua;
            this.labelFriendsCounter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFriendsCounter.Location = new System.Drawing.Point(150, 156);
            this.labelFriendsCounter.Name = "labelFriendsCounter";
            this.labelFriendsCounter.Size = new System.Drawing.Size(13, 15);
            this.labelFriendsCounter.TabIndex = 5;
            this.labelFriendsCounter.Text = "0";
            this.labelFriendsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // listViewContactList
            // 
            this.listViewContactList.BackColor = System.Drawing.Color.Gainsboro;
            this.listViewContactList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewContactList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFavorite,
            this.columnName,
            this.columnPhone,
            this.columnEmail});
            this.listViewContactList.Location = new System.Drawing.Point(214, 66);
            this.listViewContactList.Name = "listViewContactList";
            this.listViewContactList.Size = new System.Drawing.Size(585, 372);
            this.listViewContactList.TabIndex = 8;
            this.listViewContactList.UseCompatibleStateImageBehavior = false;
            // 
            // columnFavorite
            // 
            this.columnFavorite.Text = "Favorite";
            this.columnFavorite.Width = 59;
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            this.columnName.Width = 200;
            // 
            // columnPhone
            // 
            this.columnPhone.Text = "Phone";
            this.columnPhone.Width = 168;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 158;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(12, 413);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 25);
            this.buttonExit.TabIndex = 9;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.Exit);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(12, 363);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(163, 25);
            this.buttonDelete.TabIndex = 9;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEdit.Location = new System.Drawing.Point(12, 332);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(163, 25);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.Color.Aquamarine;
            this.labelInfo.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.Location = new System.Drawing.Point(-5, 37);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(800, 17);
            this.labelInfo.TabIndex = 10;
            this.labelInfo.Text = "                              ▼    Name                     Phone                " +
    "Email             ";
            // 
            // buttonFavourite
            // 
            this.buttonFavourite.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFavourite.Location = new System.Drawing.Point(12, 301);
            this.buttonFavourite.Name = "buttonFavourite";
            this.buttonFavourite.Size = new System.Drawing.Size(163, 25);
            this.buttonFavourite.TabIndex = 9;
            this.buttonFavourite.Text = "Favourite";
            this.buttonFavourite.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.buttonFavourite);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.listViewContactList);
            this.Controls.Add(this.labelFriendsCounter);
            this.Controls.Add(this.labelPrivateCounter);
            this.Controls.Add(this.labelFamilyCounter);
            this.Controls.Add(this.labelWorkCounter);
            this.Controls.Add(this.labelFriends);
            this.Controls.Add(this.labelPrivate);
            this.Controls.Add(this.labelFamily);
            this.Controls.Add(this.labelWork);
            this.Controls.Add(this.labelContactsCounter);
            this.Controls.Add(this.labelAllContacts);
            this.Controls.Add(this.buttonAddNew);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Contacts";
            this.ResumeLayout(false);
            this.PerformLayout();

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
        public ColumnHeader columnFavorite;
        public ColumnHeader columnPhone;
        public ColumnHeader columnEmail;
        private Button buttonExit;
        private Button buttonDelete;
        private Button buttonEdit;
        private ContextMenuStrip contextMenuStrip1;
        private Label labelInfo;
        private Button buttonFavourite;
        private ColumnHeader columnName;
        public ListView listViewContactList;
    }
}