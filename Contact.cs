using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD___Contacts {
    enum ContactType {
        Family,
        Private,
        Friends,
        Work
    }

    public class Contact {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string type { get; set; }
        public bool isFavourite { get; set; }

        public Contact(string name, string email, string phone, ContactType type, bool isFavourite) {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.type = type.ToString();
            this.isFavourite = isFavourite;
        }
    }
}