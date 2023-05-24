namespace CRUD___Contacts
{
    partial class Add
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
            labelAddContactSing = new Label();
            labelName = new Label();
            buttonAdd = new Button();
            textBoxName = new TextBox();
            labelPhone = new Label();
            textBoxPhone = new TextBox();
            labelEmail = new Label();
            textBoxEmail = new TextBox();
            labelType = new Label();
            comboBoxType = new ComboBox();
            checkBoxIsFavorite = new CheckBox();
            buttonCancle = new Button();
            SuspendLayout();
            // 
            // labelAddContactSing
            // 
            labelAddContactSing.BackColor = Color.DarkSlateBlue;
            labelAddContactSing.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddContactSing.ForeColor = Color.White;
            labelAddContactSing.Location = new Point(0, 9);
            labelAddContactSing.Name = "labelAddContactSing";
            labelAddContactSing.Size = new Size(528, 20);
            labelAddContactSing.TabIndex = 0;
            labelAddContactSing.Text = ">> Add contact <<";
            labelAddContactSing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.BackColor = Color.DarkSlateBlue;
            labelName.Font = new Font("Cascadia Mono", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(0, 44);
            labelName.Name = "labelName";
            labelName.Size = new Size(528, 18);
            labelName.TabIndex = 0;
            labelName.Text = " Name:                      ";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(183, 168);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 24);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += AddContact;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.Aquamarine;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxName.ForeColor = Color.Black;
            textBoxName.Location = new Point(310, 45);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(206, 16);
            textBoxName.TabIndex = 2;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPhone
            // 
            labelPhone.BackColor = Color.DarkSlateBlue;
            labelPhone.Font = new Font("Cascadia Mono", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhone.ForeColor = Color.White;
            labelPhone.Location = new Point(0, 64);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(528, 18);
            labelPhone.TabIndex = 0;
            labelPhone.Text = " Phone:                     ";
            labelPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.Aquamarine;
            textBoxPhone.BorderStyle = BorderStyle.None;
            textBoxPhone.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPhone.ForeColor = Color.Black;
            textBoxPhone.Location = new Point(310, 64);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(206, 16);
            textBoxPhone.TabIndex = 2;
            textBoxPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // labelEmail
            // 
            labelEmail.BackColor = Color.DarkSlateBlue;
            labelEmail.Font = new Font("Cascadia Mono", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(0, 84);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(528, 18);
            labelEmail.TabIndex = 0;
            labelEmail.Text = " Email:";
            labelEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.Aquamarine;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEmail.ForeColor = Color.Black;
            textBoxEmail.Location = new Point(310, 84);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(206, 16);
            textBoxEmail.TabIndex = 2;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // labelType
            // 
            labelType.BackColor = Color.DarkSlateBlue;
            labelType.Font = new Font("Cascadia Mono", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelType.ForeColor = Color.White;
            labelType.Location = new Point(0, 103);
            labelType.Name = "labelType";
            labelType.Size = new Size(528, 25);
            labelType.TabIndex = 0;
            labelType.Text = " Type:";
            labelType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.Aquamarine;
            comboBoxType.FlatStyle = FlatStyle.System;
            comboBoxType.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxType.ForeColor = Color.Black;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Family", "Friend", "Private", "Work" });
            comboBoxType.Location = new Point(310, 103);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(206, 25);
            comboBoxType.TabIndex = 3;
            // 
            // checkBoxIsFavorite
            // 
            checkBoxIsFavorite.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxIsFavorite.ForeColor = Color.White;
            checkBoxIsFavorite.Location = new Point(425, 134);
            checkBoxIsFavorite.Name = "checkBoxIsFavorite";
            checkBoxIsFavorite.Size = new Size(91, 21);
            checkBoxIsFavorite.TabIndex = 4;
            checkBoxIsFavorite.Text = "Favorite";
            checkBoxIsFavorite.UseVisualStyleBackColor = true;
            // 
            // buttonCancle
            // 
            buttonCancle.Anchor = AnchorStyles.None;
            buttonCancle.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancle.Location = new Point(264, 168);
            buttonCancle.Name = "buttonCancle";
            buttonCancle.Size = new Size(75, 24);
            buttonCancle.TabIndex = 1;
            buttonCancle.Text = "Cancle";
            buttonCancle.UseVisualStyleBackColor = true;
            buttonCancle.Click += CancleAddContact;
            // 
            // Add
            // 
            AcceptButton = buttonAdd;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            CancelButton = buttonCancle;
            ClientSize = new Size(528, 204);
            Controls.Add(checkBoxIsFavorite);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxName);
            Controls.Add(buttonCancle);
            Controls.Add(buttonAdd);
            Controls.Add(labelType);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelName);
            Controls.Add(labelAddContactSing);
            Name = "Add";
            Text = "Add";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddContactSing;
        private Label labelName;
        private Button buttonAdd;
        private TextBox textBoxName;
        private Label labelPhone;
        private TextBox textBoxPhone;
        private Label labelEmail;
        private TextBox textBoxEmail;
        private Label labelType;
        private ComboBox comboBoxType;
        private CheckBox checkBoxIsFavorite;
        private Button buttonCancle;
    }
}