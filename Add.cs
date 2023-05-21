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
    public partial class Add: Form {
        public Contact contact { get; set; }
        public Add() {
            InitializeComponent();
        }

        private void AddContact(object sender, EventArgs e) {
            
        }
    }
}