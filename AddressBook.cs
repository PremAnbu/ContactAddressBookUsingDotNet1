using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsLogical
{
    public class AddressBook
    {
         public static void Main(string[] args)
        {
            List<Contacts> contacts = new List<Contacts>();
            while (true)
            {
                Console.WriteLine("Enter \n 1.Add Person Details in Address Book" +
                "\n 2.Update Person Details in Address Book \n 3.Delete Person Details in Address Book" +
                "\n 4.Display Details");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:

                        AddContacts addContacts = new AddContactDetails();
                        addContacts.addContact(contacts);
                        break;
                    case 2:
                        UpdateContact contactPerson = new ContactUpdate();
                        contactPerson.updateContact(contacts);                        break;
                    case 3:
                        DeleteContact contactPerson1 = new ContactDelete();
                        contactPerson1.deleteContact(contacts);                        break;
                    case 4:
                        foreach (Contacts c in contacts)
                        {
                            Console.WriteLine($"FirstName : {c.FirstName}, LastName : {c.LastName}," +
                                $"PhoneNo : {c.PhoneNo}, Email : {c.Email}, Address : {c.City}," +
                                $"State : {c.State}, Zip : {c.Zip}");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                Console.WriteLine(" you want to add another task please enter {Y/N}");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }

        }
    }
}
