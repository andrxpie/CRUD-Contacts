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
    public partial class View : Form
    {
        internal View(Contact contact)
        {
            InitializeComponent();
            labelName.Text += contact.name;
            labelPhone.Text += contact.phone;
            labelEmail.Text += contact.email;
            labelType.Text += contact.type;
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}