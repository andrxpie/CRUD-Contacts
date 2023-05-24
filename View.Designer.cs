namespace CRUD___Contacts
{
    partial class View
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
            labelView = new Label();
            labelName = new Label();
            labelPhone = new Label();
            labelEmail = new Label();
            labelType = new Label();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // labelView
            // 
            labelView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelView.BackColor = Color.DarkSlateBlue;
            labelView.Font = new Font("Cascadia Mono SemiBold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelView.ForeColor = Color.White;
            labelView.Location = new Point(0, 11);
            labelView.Name = "labelView";
            labelView.Size = new Size(528, 20);
            labelView.TabIndex = 0;
            labelView.Text = ">> View <<";
            labelView.TextAlign = ContentAlignment.TopCenter;
            // 
            // labelName
            // 
            labelName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelName.BackColor = Color.DarkSlateBlue;
            labelName.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(0, 46);
            labelName.Name = "labelName";
            labelName.Size = new Size(528, 18);
            labelName.TabIndex = 0;
            labelName.Text = " Name: ";
            labelName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelPhone
            // 
            labelPhone.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelPhone.BackColor = Color.DarkSlateBlue;
            labelPhone.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelPhone.ForeColor = Color.White;
            labelPhone.Location = new Point(0, 66);
            labelPhone.Name = "labelPhone";
            labelPhone.Size = new Size(528, 18);
            labelPhone.TabIndex = 0;
            labelPhone.Text = " Phone: ";
            labelPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelEmail
            // 
            labelEmail.BackColor = Color.DarkSlateBlue;
            labelEmail.Font = new Font("Cascadia Mono", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.ForeColor = Color.White;
            labelEmail.Location = new Point(0, 86);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(528, 18);
            labelEmail.TabIndex = 6;
            labelEmail.Text = " Email: ";
            labelEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // labelType
            // 
            labelType.BackColor = Color.DarkSlateBlue;
            labelType.Font = new Font("Cascadia Mono SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelType.ForeColor = Color.White;
            labelType.Location = new Point(0, 106);
            labelType.Name = "labelType";
            labelType.Size = new Size(528, 25);
            labelType.TabIndex = 0;
            labelType.Text = " Type: ";
            labelType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(12, 165);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(75, 27);
            buttonExit.TabIndex = 1;
            buttonExit.Text = "Exit";
            buttonExit.TextAlign = ContentAlignment.TopCenter;
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += Exit;
            // 
            // View
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(528, 204);
            Controls.Add(buttonExit);
            Controls.Add(labelType);
            Controls.Add(labelEmail);
            Controls.Add(labelPhone);
            Controls.Add(labelName);
            Controls.Add(labelView);
            Font = new Font("Cascadia Mono SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "View";
            Text = "View";
            ResumeLayout(false);
        }

        #endregion

        private Label labelView;
        private Label labelName;
        private Label labelPhone;
        private Label labelEmail;
        private Label labelType;
        private Button buttonExit;
    }
}