using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
//using System.Data.;


namespace OopsLogical
{
    public class AddressBook
    {
        public static void Main(string[] args)
        {
            HashSet<Contacts> contacts = new HashSet<Contacts>();
            string path = "server=PREMKUMAR\\SQLEXPRESS; Initial Catalog = AddressBooks; Integrated Security = SSPI";
            SqlConnection conn = new SqlConnection(path);
            

            while (true)
            {
                Console.WriteLine("Enter \n 1.Add Person Details in Address Book" +
                "\n 2.Update Person Details in Address Book \n 3.Delete Person Details in Address Book" +
                "\n 4.Display Details");
                SqlCommand cmd = new SqlCommand("spGetContactDetails", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                SqlDataReader values = cmd.ExecuteReader();
                while (values.Read())
                {
                    if (!values.IsDBNull(0))
                    {
                        Contacts contact = new Contacts
                        {
                            FirstName = values.GetString(1),
                            LastName = values.GetString(2),
                            PhoneNo = values.GetInt64(3),
                            Email = values.GetString(4),
                            Address = values.GetString(5),
                            City = values.GetString(6),
                            State = values.GetString(7),
                            Zip = values.GetInt32(8)
                        };
                        contacts.Add(contact);
                    }
                }
                conn.Close();
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        AddContacts addContacts = new AddContactDetails();
                        addContacts.addContact(contacts, conn);
                        break;
                    case 2:
                        UpdateContact contactPerson = new ContactUpdate();
                        contactPerson.updateContact(contacts,conn); break;
                    case 3:
                        DeleteContact contactPerson1 = new ContactDelete();
                        contactPerson1.deleteContact(contacts,conn); break;
                    case 4:
                        SqlCommand scmd = new SqlCommand("spGetContactDetails", conn);
                        scmd.CommandType = CommandType.StoredProcedure;
                        conn.Open();
                        SqlDataReader sr = scmd.ExecuteReader();
                        while (sr.Read())
                        {
                            Console.WriteLine(sr[0] + "  " + sr[1] + "  " + sr[2] + "  " + sr[3] + "  " + sr[4] + "  " + sr[5] + "  " + sr[6] + "  " + sr[7] + "  " + sr[8]);
                        }
                        conn.Close();
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
