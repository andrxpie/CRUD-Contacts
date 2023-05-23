﻿namespace CRUD___Contacts
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
            SuspendLayout();
            // 
            // labelAddContactSing
            // 
            labelAddContactSing.BackColor = Color.MediumSlateBlue;
            labelAddContactSing.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddContactSing.Location = new Point(0, 9);
            labelAddContactSing.Name = "labelAddContactSing";
            labelAddContactSing.Size = new Size(528, 20);
            labelAddContactSing.TabIndex = 0;
            labelAddContactSing.Text = "          Add contact          ";
            labelAddContactSing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            labelName.BackColor = Color.MediumSlateBlue;
            labelName.Font = new Font("Cascadia Mono", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.Location = new Point(0, 44);
            labelName.Name = "labelName";
            labelName.Size = new Size(528, 18);
            labelName.TabIndex = 0;
            labelName.Text = " Name                              ";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.None;
            buttonAdd.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(222, 168);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 24);
            buttonAdd.TabIndex = 1;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += AddContact;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.MediumPurple;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxName.ForeColor = Color.White;
            textBoxName.Location = new Point(310, 44);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(206, 16);
            textBoxName.TabIndex = 2;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // labelPhone
            // 
            labelPhone.BackColor = Color.MediumSlateBlue;
            labelPhone.Font = new Font("Cascadia Mono", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhone.Location = new Point(0, 64);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(528, 18);
            labelPhone.TabIndex = 0;
            labelPhone.Text = " Phone                             ";
            labelPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.MediumPurple;
            textBoxPhone.BorderStyle = BorderStyle.None;
            textBoxPhone.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPhone.ForeColor = Color.White;
            textBoxPhone.Location = new Point(310, 64);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(206, 16);
            textBoxPhone.TabIndex = 2;
            textBoxPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // labelEmail
            // 
            labelEmail.BackColor = Color.MediumSlateBlue;
            labelEmail.Font = new Font("Cascadia Mono", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(0, 84);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(528, 18);
            labelEmail.TabIndex = 0;
            labelEmail.Text = " Email                             ";
            labelEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.MediumPurple;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEmail.ForeColor = Color.White;
            textBoxEmail.Location = new Point(310, 84);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(206, 16);
            textBoxEmail.TabIndex = 2;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // labelType
            // 
            labelType.BackColor = Color.MediumSlateBlue;
            labelType.Font = new Font("Cascadia Mono", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelType.Location = new Point(0, 111);
            labelType.Name = "labelType";
            labelType.Size = new Size(528, 25);
            labelType.TabIndex = 0;
            labelType.Text = " Type                              ";
            labelType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.MediumPurple;
            comboBoxType.FlatStyle = FlatStyle.System;
            comboBoxType.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxType.ForeColor = Color.White;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Family", "Friend", "Private", "Work" });
            comboBoxType.Location = new Point(310, 111);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(206, 25);
            comboBoxType.TabIndex = 3;
            // 
            // checkBoxIsFavorite
            // 
            checkBoxIsFavorite.AutoSize = true;
            checkBoxIsFavorite.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxIsFavorite.Location = new Point(425, 142);
            checkBoxIsFavorite.Name = "checkBoxIsFavorite";
            checkBoxIsFavorite.Size = new Size(91, 21);
            checkBoxIsFavorite.TabIndex = 4;
            checkBoxIsFavorite.Text = "Favorite";
            checkBoxIsFavorite.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 204);
            Controls.Add(checkBoxIsFavorite);
            Controls.Add(comboBoxType);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxPhone);
            Controls.Add(textBoxName);
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
    }
}