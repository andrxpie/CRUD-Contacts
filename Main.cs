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

        public void RefreshRTB()
        {
            richTextBoxContacts.Text = string.Empty;
            foreach (Contact contact in contacts)
                richTextBoxContacts.Text += contact.ToString() + "\n";
        }

        public void RefreshCounters()
        {
            labelAllContactsCounter.Text = contacts.Count.ToString();
            labelFamilyCounter.Text = contacts.Count(x => x.type == "Family").ToString();
            labelFriendCounter.Text = contacts.Count(x => x.type == "Friend").ToString();
            labelPrivateCounter.Text = contacts.Count(x => x.type == "Private").ToString();
            labelWorkCounter.Text = contacts.Count(x => x.type == "Work").ToString();
        }

        public void AddContact(object sender, EventArgs e)
        {
            Add add = new Add();
            if (add.ShowDialog() == DialogResult.Cancel)
            {
                richTextBoxOutput.Text = " Output: canceled adding new contact";
                return;
            }

            contacts.Add(add.contact);

            RefreshRTB();
            RefreshCounters();

            richTextBoxOutput.Text = $" Output: succesfully added new contact \"{contacts.Last().name}\"";
        }

        public void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DeleteContact(object sender, EventArgs e)
        {
            var names = contacts.Select(x => x.name);

            if (names.Contains(textBoxMatchName.Text))
            {
                Contact contact = contacts.Where(x => x.name == textBoxMatchName.Text).First();
                contacts.Remove(contact);

                RefreshRTB();
                RefreshCounters();

                richTextBoxOutput.Text = $" Output: succesfully deleted \"{textBoxMatchName.Text}\"";
                textBoxMatchName.Text = string.Empty;
            }
            else
            {
                richTextBoxOutput.Text = " Output: no matches found";
                textBoxMatchName.Text = string.Empty;
            }
        }
    }
}