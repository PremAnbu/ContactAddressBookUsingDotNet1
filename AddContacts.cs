using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsLogical
{
    interface AddContacts
    {
        List<Contacts> addContact(List<Contacts> lContact);

    }
    public class AddContactDetails : AddContacts
    {
        public List<Contacts> addContact(List<Contacts> lContact)
        {
            Console.WriteLine("Enter Adderss Book Details");
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
            Contacts cont = new Contacts();
            lContact.Add(new Contacts
            {
                FirstName = first,
                LastName = last,
                PhoneNo = phno,
                Email = email,
                Address = address,
                City = city,
                State = state,
                Zip = zip
            });
            return lContact;
        }

    }
}
