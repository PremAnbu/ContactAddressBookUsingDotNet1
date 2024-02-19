using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OopsLogical
{
    public class AddressBook
    {
        public static void Main(string[] args)
        {
            string path = "C:\\DotNet\\OopsLogical\\OopsLogical\\AddressBookObjects.csv";
           // File.WriteAllText(path, String.Empty);
            if (!File.Exists(path))
                File.CreateText(path);
            List<string> lines = File.ReadAllLines(path).ToList();
            HashSet<Contacts> contacts = new HashSet<Contacts>();
            try
            {
                if (lines.Count > 0)
                {
                    foreach (string line in lines)
                    {
                        string[] values = line.Split(',');
                        Contacts contact = new Contacts
                        {
                            FirstName = values[0],LastName = values[1],PhoneNo = long.Parse(values[2]),Email = values[3],
                            Address = values[4],City = values[5],State = values[6],Zip = int.Parse(values[7])
                        };
                        contacts.Add(contact);
                    }
                }
                else
                    Console.WriteLine("File is empty.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
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
                        contactPerson.updateContact(contacts); break;
                    case 3:
                        DeleteContact contactPerson1 = new ContactDelete();
                        contactPerson1.deleteContact(contacts); break;
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
            StreamWriter s = null;
            try
            {
                s = new StreamWriter(path, append: false);
                s.AutoFlush = true;
               // if (lines.Count == 0)
                //   lines.Add("FirstName,LastName,PhoneNo,Email,Address,City,State,Zip");
                foreach (var item in contacts)
                {
                    s.WriteLine($"{item.FirstName},{item.LastName},{item.PhoneNo},{item.Email},{item.Address},{item.City},{item.State},{item.Zip}");
                }
                Console.WriteLine("Employee data saved to CSV file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                if (s != null)
                    s.Close();
            }
        } 
        
    }
}
