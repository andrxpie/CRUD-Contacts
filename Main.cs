using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
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
            menuStrip1.BackColor = Color.Aquamarine;
            menuStrip1.ForeColor = Color.Black;
        }

        public void RefreshRTB()
        {
            int counter = 0;
            richTextBoxContacts.Text = string.Empty;
            foreach (Contact contact in contacts) {
                if(counter < 9) richTextBoxContacts.Text += $"  {++counter}   {contact.ToString()}\n";
                else if(counter < 100) richTextBoxContacts.Text += $"  {++counter}  {contact.ToString()}\n";
            }
        }

        public void RefreshCounters()
        {
            labelAllContactsCounter.Text = contacts.Count.ToString();
            labelFamilyCounter.Text = contacts.Count(x => x.type == "Family").ToString();
            labelFriendCounter.Text = contacts.Count(x => x.type == "Friend").ToString();
            labelPrivateCounter.Text = contacts.Count(x => x.type == "Private").ToString();
            labelWorkCounter.Text = contacts.Count(x => x.type == "Work").ToString();
        }

        public void SortContacts()
        {
            IEnumerable<Contact> contactsSort = contacts.OrderBy(x => x.name);
            contacts = contactsSort.ToList();
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
            SortContacts();

            RefreshRTB();
            RefreshCounters();

            richTextBoxOutput.Text = $" Output: succesfully added new contact \"{contacts.Last().name}\"";
        }

        private void DeleteContact(object sender, EventArgs e)
        {
            if (textBoxMatchName.Text == string.Empty) return;

            if (Convert.ToInt32(textBoxMatchName.Text) > 0 && Convert.ToInt32(textBoxMatchName.Text) <= contacts.Count)
            {
                richTextBoxOutput.Text = $" Output: succesfully deleted \"{contacts[Convert.ToInt32(textBoxMatchName.Text) - 1].name}\"";

                contacts.RemoveAt(Convert.ToInt32(textBoxMatchName.Text) - 1);
                textBoxMatchName.Text = string.Empty;

                RefreshRTB();
                RefreshCounters();

                return;
            }

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

        public void ViewContact(object sender, EventArgs e)
        {
            if (textBoxMatchName.Text == string.Empty) return;

            if (Convert.ToInt32(textBoxMatchName.Text) > 0 && Convert.ToInt32(textBoxMatchName.Text) <= contacts.Count)
            {
                View view = new View(contacts[Convert.ToInt32(textBoxMatchName.Text) - 1]);
                view.ShowDialog();

                richTextBoxOutput.Text = $" Output: succesfully viewed contact \"{contacts[Convert.ToInt32(textBoxMatchName.Text) - 1].name}\"";
                textBoxMatchName.Text = string.Empty;

                return;
            }

            var names = contacts.Select(x => x.name);

            if (names.Contains(textBoxMatchName.Text))
            {
                Contact contact = contacts.Where(x => x.name == textBoxMatchName.Text).First();
                View view = new View(contact);
                view.ShowDialog();

                richTextBoxOutput.Text = $" Output: succesfully viewed contact \"{textBoxMatchName.Text}\"";
                textBoxMatchName.Text = string.Empty;
            }
            else
            {
                richTextBoxOutput.Text = " Output: no matches found";
                textBoxMatchName.Text = string.Empty;
            }
        }

        public void EditContact(object sender, EventArgs e)
        {
            if (textBoxMatchName.Text == string.Empty) return;

            try
            {
                if (Convert.ToInt32(textBoxMatchName.Text) > 0 && Convert.ToInt32(textBoxMatchName.Text) <= contacts.Count)
                {
                    Contact contactEdit = contacts[Convert.ToInt32(textBoxMatchName.Text) - 1];

                    Edit edit = new Edit(contactEdit);
                    if (edit.ShowDialog() == DialogResult.Cancel)
                    {
                        richTextBoxOutput.Text = " Output: canceled editing contact";
                        textBoxMatchName.Text = string.Empty;
                        return;
                    }

                    contacts.Add(edit.contact);
                    SortContacts();

                    Contact contactDelete = contacts[Convert.ToInt32(textBoxMatchName.Text) - 1];
                    contacts.Remove(contactDelete);

                    RefreshRTB();
                    RefreshCounters();

                    richTextBoxOutput.Text = $" Output: succesfully edited contact \"{contacts[Convert.ToInt32(textBoxMatchName.Text) - 1].name}\"";
                    textBoxMatchName.Text = string.Empty;

                    return;
                }
            }
            catch { }

            var names = contacts.Select(x => x.name);

            if (names.Contains(textBoxMatchName.Text))
            {
                Contact contactEdit = contacts.Where(x => x.name == textBoxMatchName.Text).First();
                Edit edit = new Edit(contactEdit);
                if (edit.ShowDialog() == DialogResult.Cancel)
                {
                    richTextBoxOutput.Text = " Output: canceled editing contact";
                    textBoxMatchName.Text = string.Empty;
                    return;
                }

                contacts.Add(edit.contact);
                SortContacts();

                Contact contactDelete = contacts.Where(x => x.name == textBoxMatchName.Text).First();
                contacts.Remove(contactDelete);

                RefreshRTB();
                RefreshCounters();

                richTextBoxOutput.Text = $" Output: succesfully edited contact \"{textBoxMatchName.Text}\"";
                textBoxMatchName.Text = string.Empty;
            }
            else
            {
                richTextBoxOutput.Text = " Output: no matches found";
                textBoxMatchName.Text = string.Empty;
            }
        }

        public void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OpenContacts(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        contacts = JsonConvert.DeserializeObject<List<Contact>>(sr.ReadToEnd());
                        sr.Close();

                        SortContacts();

                        RefreshRTB();
                        RefreshCounters();

                        richTextBoxOutput.Text = $" Output: succesfully loaded contacts from \"{openFileDialog1.FileName}\"";
                    }
                }
                catch
                {
                    richTextBoxOutput.Text = $" Output: failed loading contacts from file \"{saveFileDialog1.FileName}\"";
                }
            }
        }

        private void SaveContacts(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        sw.Write(JsonConvert.SerializeObject(contacts));
                        sw.Close();
                        richTextBoxOutput.Text = $" Output: succusfully saved contacts in file \"{saveFileDialog1.FileName}\"";
                    }
                }
                catch
                {
                    richTextBoxOutput.Text = $" Output: failed saving contacts in file \"{saveFileDialog1.FileName}\"";
                }
            }
        }
    }
}