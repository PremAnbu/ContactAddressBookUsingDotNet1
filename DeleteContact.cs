using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsLogical
{
    interface DeleteContact
    {
        List<Contacts> deleteContact(List<Contacts> lContact);

    }
    public class ContactDelete : DeleteContact
    {
       public  List<Contacts> deleteContact(List<Contacts> lContact){
          Console.WriteLine("Enter First Name which person details want to delete");
                        Console.WriteLine("Enter First Name");
                        string first = Console.ReadLine();
        Contacts cont = lContact.Find(contact => contact.FirstName.Equals(first));
            if (cont!= null)
                 lContact.Remove(cont);
            else
                Console.WriteLine("Contact NOt present");
            return lContact;

    }
}
