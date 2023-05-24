using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD___Contacts {
    internal class Contact {
        public string name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string type { get; set; }
        public bool isFavorite { get; set; }

        public Contact(string name, string phone, string email, string type, bool isFavourite) {
            this.name = name;
            this.phone = phone;
            this.email = email;
            this.type = type;
            this.isFavorite = isFavourite;
        }

        public override string ToString() {
            string contact = string.Empty;

            if (isFavorite) contact += "▼";
            else contact += "▽";

            if (name.Length == 16) contact += $"   {name}";
            else if (name.Length < 16) {
                string nameCut = name;

                int countSpaces = 16 - name.Length;
                for (int i = 0; i < countSpaces; i++) nameCut += " ";

                contact += $"   {nameCut}";
            }
            else if (name.Length > 16) {
                string nameCut = string.Empty;

                for (int i = 0; i < 13; i++) {
                    nameCut += name[i];
                } nameCut += "...";

                contact += $"   {nameCut}";
            }

            if (phone.Length == 15) contact += $"     {phone}";
            else if (phone.Length < 15) {
                string phoneCut = phone;

                int countSpaces = 15 - phone.Length;
                for (int i = 0; i < countSpaces; i++) phoneCut += " ";

                contact += $"     {phoneCut}";
            }
            else if (phone.Length > 15) {
                string phoneCut = string.Empty;

                for (int i = 0; i < 12; i++) {
                    phoneCut += phone[i];
                } phoneCut += "...";
                contact += $"     {phoneCut}";
            }

            if (email.Length == 20) contact += $"     {email}";
            else if (email.Length < 20) {
                string emailCut = email;

                int countSpaces = 20 - email.Length;
                for (int i = 0; i < countSpaces; i++) emailCut += " ";

                contact += $"     {emailCut}";
            }
            else if (email.Length > 20) {
                string emailCut = string.Empty;
                int indexOfDog = email.IndexOf('@'), 
                    lengthAfterDog = email.Length - indexOfDog, 
                    maxAddressNameLength = 20 - lengthAfterDog - 4;

                // verylongmail@gmail.com - приклад

                for (int i = 0; i < maxAddressNameLength - 1; i++)
                    emailCut += email[i];
                emailCut += "...";
                emailCut += email[indexOfDog - 1];
                for (int i = 0, k = indexOfDog; i < lengthAfterDog; i++, k++)
                    emailCut += email[k];
                int countSpaces = 20 - emailCut.Length;
                for (int i = 0; i < countSpaces; i++)
                    emailCut += " ";

                //emailCut += email[0] + "...";
                //for (int i = indexOfDog - 1; i < email.Length; i++)
                //    emailCut += email[i];
                //int countSpaces = 20 - emailCut.Length;
                //for (int i = 0; i < countSpaces; i++)
                //    emailCut += " "; // v...l@gmail.com - скорочує адресу (платформа остається в цілісності) | 1

                //for (int i = 0; i < 17; i++) { // verylongmail@gmai... - скорочує останні символи | 2
                //    emailCut += email[i];
                //} emailCut += "...";

                contact += $"     {emailCut}";
            }

            contact += $"       {type}";

            return contact;
        }
    }
}