using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsLogical
{
    interface UpdateContact
    {
        List<Contacts> updateContact(List<Contacts> lContact);
    }
    class ContactUpdate : UpdateContact
    {
        public List<Contacts> updateContact(List<Contacts> lContact)
        {
            Console.WriteLine("Enter First Name which person details to Update");
            string firstup = Console.ReadLine();
            Console.WriteLine("Enter First Name");
            string first = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string last = Console.ReadLine();
            Console.WriteLine("Enter Phone No");
            long phno = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            Console.WriteLine("Enter Zip");
            int zip = int.Parse(Console.ReadLine());
            Contacts cont = lContact.Find(contact => contact.FirstName.Equals(firstup));
            if (cont != null)
            {
                cont.FirstName = first;
                cont.LastName = last;
                cont.PhoneNo = phno;
                cont.Email = email;
                cont.Address = address;
                cont.City = city;
                cont.State = state;
                cont.Zip = zip;

            }
            else
                Console.WriteLine("Contact Not present");
            return lContact;
        }
     
    }
}
