using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD___Contacts
{
    public partial class Add : Form
    {
        internal Contact contact { get; set; }

        internal Add()
        {
            InitializeComponent();
        }

        private bool checkType()
        {
            if (comboBoxType.Text == string.Empty)
            {
                labelType.Text = " Type -> type empty";
                comboBoxType.Focus();
                return false;
            }
            else
            {
                labelType.Text = " Type";
                return true;
            }
        }

        private bool checkEmail()
        {
            if (textBoxEmail.Text == string.Empty)
            {
                labelEmail.Text = " Email -> email empty";
                textBoxEmail.Focus();
                return false;
            }
            else
            {
                labelEmail.Text = " Email";
                return true;
            }
        }

        private bool checkPhone()
        {
            if (textBoxPhone.Text == string.Empty)
            {
                labelPhone.Text = " Phone -> phone empty";
                textBoxPhone.Focus();
                return false;
            }
            else
            {
                labelPhone.Text = " Phone";
                return true;
            }
        }

        private bool checkName()
        {
            if (textBoxName.Text == string.Empty)
            {
                labelName.Text = " Name -> name empty";
                textBoxName.Focus();
                return false;
            }
            else
            {
                labelName.Text = " Name";
                return true;
            }
        }

        private void AddContact(object sender, EventArgs e)
        {
            if (checkType() && checkEmail() && checkPhone() && checkName())
            {
                contact = new Contact(textBoxName.Text, textBoxPhone.Text, textBoxEmail.Text, comboBoxType.Text, checkBoxIsFavorite.Checked);
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
        }

        private void CancleAddContact(object sender, EventArgs e) { 
            this.DialogResult = DialogResult.Cancel;
        }
    }
}