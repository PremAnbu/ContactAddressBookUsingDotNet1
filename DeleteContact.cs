using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OopsLogical
{
    interface DeleteContact
    {
        HashSet<Contacts> deleteContact(HashSet<Contacts> lContact);

    }
    public class ContactDelete : DeleteContact
    {
        public HashSet<Contacts> deleteContact(HashSet<Contacts> lContact)
        {
            Console.WriteLine("Enter First Name which person details want to delete");
            string first = Console.ReadLine();
            Console.WriteLine("Enter last Name");
            string last = Console.ReadLine();
            // Contacts cont = lContact.Find(contact => contact.FirstName.Equals(first));
            string firstRegex = "[A-Z]{1}[a-zA-Z]{0,20}";
            string lastRegex = "[a-zA-Z]";
            bool check = true;
            try {
                if ((!Regex.IsMatch(first, firstRegex)) || (!Regex.IsMatch(last, lastRegex))) {
                    check = false;
                    throw new InvalidNameException("Invalid Name Please Enter valid Detail !!!");
                }
            }
            catch (InvalidNameException ex) {
                Console.WriteLine("Error  : " + ex.Message);
            }
            catch (Exception ex) {
                Console.WriteLine("Invalid Contact Address Detail: " + ex.Message);
            }
            if (check == false) {
                Console.WriteLine("Please Enter correct AddressBook Details");
                return lContact;
            }
            Contacts cont = null;
            foreach (var contact in lContact) {
                if (contact.FirstName.Equals(first) && contact.LastName.Equals(last)) {
                    cont = contact;
                    break;
                }
            }
            if (cont != null) {
                lContact.Remove(cont);
                Console.WriteLine("Contact Deleted");
            }
            else
                Console.WriteLine("Contact NOt present");
            return lContact;
        }
    }
}
