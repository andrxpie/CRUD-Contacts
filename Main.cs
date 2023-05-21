using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD___Contacts {
    public partial class Main: Form {
        List<Contact> contacts;

        public Main() {
            InitializeComponent();
            contacts = new List<Contact>();
        }

        public void AddContact(object sender, EventArgs e) {
            Add add = new Add();
            add.ShowDialog();
        }

        public void Exit(object sender, EventArgs e) {
            Application.Exit();
        }
    }
}
