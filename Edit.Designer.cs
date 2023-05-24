namespace CRUD___Contacts
{
    partial class Edit
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
            checkBoxIsFavorite = new CheckBox();
            comboBoxType = new ComboBox();
            textBoxEmail = new TextBox();
            textBoxPhone = new TextBox();
            textBoxName = new TextBox();
            buttonCancle = new Button();
            buttonDone = new Button();
            labelType = new Label();
            labelEmail = new Label();
            labelPhone = new Label();
            labelName = new Label();
            labelAddContactSing = new Label();
            SuspendLayout();
            // 
            // checkBoxIsFavorite
            // 
            checkBoxIsFavorite.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxIsFavorite.ForeColor = Color.White;
            checkBoxIsFavorite.Location = new Point(425, 136);
            checkBoxIsFavorite.Name = "checkBoxIsFavorite";
            checkBoxIsFavorite.Size = new Size(91, 21);
            checkBoxIsFavorite.TabIndex = 16;
            checkBoxIsFavorite.Text = "Favorite";
            checkBoxIsFavorite.UseVisualStyleBackColor = true;
            // 
            // comboBoxType
            // 
            comboBoxType.BackColor = Color.Aquamarine;
            comboBoxType.FlatStyle = FlatStyle.System;
            comboBoxType.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxType.ForeColor = Color.Black;
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Items.AddRange(new object[] { "Family", "Friend", "Private", "Work" });
            comboBoxType.Location = new Point(264, 104);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(252, 25);
            comboBoxType.TabIndex = 15;
            // 
            // textBoxEmail
            // 
            textBoxEmail.BackColor = Color.Aquamarine;
            textBoxEmail.BorderStyle = BorderStyle.None;
            textBoxEmail.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEmail.ForeColor = Color.Black;
            textBoxEmail.Location = new Point(264, 85);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(252, 16);
            textBoxEmail.TabIndex = 12;
            textBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPhone
            // 
            textBoxPhone.BackColor = Color.Aquamarine;
            textBoxPhone.BorderStyle = BorderStyle.None;
            textBoxPhone.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPhone.ForeColor = Color.Black;
            textBoxPhone.Location = new Point(264, 65);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(252, 16);
            textBoxPhone.TabIndex = 13;
            textBoxPhone.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.Aquamarine;
            textBoxName.BorderStyle = BorderStyle.None;
            textBoxName.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxName.ForeColor = Color.Black;
            textBoxName.Location = new Point(264, 45);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(252, 16);
            textBoxName.TabIndex = 14;
            textBoxName.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonCancle
            // 
            buttonCancle.Anchor = AnchorStyles.None;
            buttonCancle.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancle.Location = new Point(264, 170);
            buttonCancle.Name = "buttonCancle";
            buttonCancle.Size = new Size(75, 24);
            buttonCancle.TabIndex = 10;
            buttonCancle.Text = "Cancle";
            buttonCancle.UseVisualStyleBackColor = true;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.None;
            buttonDone.Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDone.Location = new Point(183, 170);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(75, 24);
            buttonDone.TabIndex = 11;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += EditContact;
            // 
            // labelType
            // 
            labelType.BackColor = Color.DarkSlateBlue;
            labelType.Font = new Font("Cascadia Mono", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelType.ForeColor = Color.White;
            labelType.Location = new Point(0, 104);
            labelType.Name = "labelType";
            labelType.Size = new Size(528, 25);
            labelType.TabIndex = 5;
            labelType.Text = " Type:";
            labelType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelEmail
            // 
            labelEmail.BackColor = Color.DarkSlateBlue;
            labelEmail.Font = new Font("Cascadia Mono", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(0, 84);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(528, 18);
            labelEmail.TabIndex = 6;
            labelEmail.Text = " Email:";
            labelEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPhone
            // 
            labelPhone.BackColor = Color.DarkSlateBlue;
            labelPhone.Font = new Font("Cascadia Mono", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhone.ForeColor = Color.White;
            labelPhone.Location = new Point(0, 64);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(528, 18);
            labelPhone.TabIndex = 7;
            labelPhone.Text = " Phone:                     ";
            labelPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelName
            // 
            labelName.BackColor = Color.DarkSlateBlue;
            labelName.Font = new Font("Cascadia Mono", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(0, 44);
            labelName.Name = "labelName";
            labelName.Size = new Size(528, 18);
            labelName.TabIndex = 8;
            labelName.Text = " Name:                      ";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelAddContactSing
            // 
            labelAddContactSing.BackColor = Color.DarkSlateBlue;
            labelAddContactSing.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelAddContactSing.ForeColor = Color.White;
            labelAddContactSing.Location = new Point(0, 9);
            labelAddContactSing.Name = "labelAddContactSing";
            labelAddContactSing.Size = new Size(528, 20);
            labelAddContactSing.TabIndex = 9;
            labelAddContactSing.Text = ">> Edit contact <<";
            labelAddContactSing.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Edit
            // 
            AcceptButton = buttonDone;
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
            Controls.Add(buttonDone);
            Controls.Add(labelType);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelName);
            Controls.Add(labelAddContactSing);
            Name = "Edit";
            Text = "Edit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxIsFavorite;
        private ComboBox comboBoxType;
        private TextBox textBoxEmail;
        private TextBox textBoxPhone;
        private TextBox textBoxName;
        private Button buttonCancle;
        private Button buttonDone;
        private Label labelType;
        private Label labelEmail;
        private Label labelPhone;
        private Label labelName;
        private Label labelAddContactSing;
    }
}