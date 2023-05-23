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
    public partial class Main : Form
    {
        List<Contact> contacts;

        public Main()
        {
            InitializeComponent();
            contacts = new List<Contact>();
        }

        public void AddContact(object sender, EventArgs e)
        {
            Add add = new Add();
            add.ShowDialog();
            contacts.Add(add.contact);

            richTextBoxContacts.Text = string.Empty;
            foreach (Contact contact in contacts)
                richTextBoxContacts.Text += contact.ToString() + "\n";

            labelContactsCounter.Text = contacts.Count().ToString();

            if (contacts[contacts.Count - 1].type == "Family") labelFamilyCounter.Text = (Convert.ToInt32(labelFamilyCounter.Text) + 1).ToString();
            if (contacts[contacts.Count - 1].type == "Friend") labelFriendsCounter.Text = (Convert.ToInt32(labelFriendsCounter.Text) + 1).ToString();
            if (contacts[contacts.Count - 1].type == "Private") labelPrivateCounter.Text = (Convert.ToInt32(labelPrivateCounter.Text) + 1).ToString();
            if (contacts[contacts.Count - 1].type == "Work") labelWorkCounter.Text = (Convert.ToInt32(labelWorkCounter.Text) + 1).ToString();
        }

        public void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}