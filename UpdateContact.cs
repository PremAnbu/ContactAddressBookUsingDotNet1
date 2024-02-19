using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OopsLogical
{
    interface UpdateContact
    {
        HashSet<Contacts> updateContact(HashSet<Contacts> lContact);
    }
    class ContactUpdate : UpdateContact
    {
        public HashSet<Contacts> updateContact(HashSet<Contacts> lContact)
        {
            Contacts cont = null;
            string firstRegex = "[A-Z]{1}[a-zA-Z]{0,20}";
            string lastRegex = "[a-zA-Z]";
            string phnoRegex = @"[6-9]{1}\d{9}";
            string emailRegex = @"[a-zA-Z0-9]{1,17}@[\w]{1,8}\.[a-zA-Z]{2,3}";
            string cityRegex = "[a-zA-Z]{3,20}";
            string stateRegex = "[a-zA-Z]{3,20}";
            string zipRegex = @"\d{6}";

            bool check = true;
            Console.WriteLine("Enter First Name which person details to Update");
            string firstup = Console.ReadLine();
            try
            {
                if (!Regex.IsMatch(firstup, firstRegex))
                {
                    check = false;
                    throw new InvalidNameException("Invalid Name Please Enter valid Detail !!!");
                }
            }
            catch (InvalidNameException ex)
            {
                Console.WriteLine("Error  : " + ex.Message);
                return lContact;
            }
            Console.WriteLine("Enter First Name");
            string first = Console.ReadLine();
            try
            {
                if (!Regex.IsMatch(first, firstRegex))
                {
                    check = false;
                    throw new InvalidNameException("Invalid Name Please Enter valid Detail !!!");
                }
            }
            catch (InvalidNameException ex)
            {
                Console.WriteLine("Error  : " + ex.Message);
                return lContact;
            }
            Console.WriteLine("Enter Last Name");
            string last = Console.ReadLine();
            try
            {
                if (!Regex.IsMatch(last, lastRegex))
                {
                    check = false;
                    throw new InvalidNameException("Invalid Name Please Enter valid Detail !!!");
                }
            }
            catch (InvalidNameException ex)
            {
                Console.WriteLine("Error  : " + ex.Message);
                return lContact;
            }
            Console.WriteLine("Enter Phone No");
            long phno = long.Parse(Console.ReadLine());
            try
            {
                if (!Regex.IsMatch(phno + "", phnoRegex))
                {
                    check = false;
                    throw new InvalidPhoneNumberException("Invalid PhoneNumber Please Enter valid Detail !!!");
                }
            }
            catch (InvalidPhoneNumberException ex)
            {
                Console.WriteLine("Error  : " + ex.Message);
                return lContact;
            }
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();
            try
            {
                if (!Regex.IsMatch(email, emailRegex))
                {
                    check = false;
                    throw new InvalidEmailException("Invalid Email Please Enter valid Detail !!!");
                }
            }
            catch (InvalidEmailException ex)
            {
                Console.WriteLine("Error  : " + ex.Message);
                return lContact;
            }
            Console.WriteLine("Enter Address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter City");
            string city = Console.ReadLine();
            try
            {
                if (!Regex.IsMatch(city, cityRegex))
                {
                    check = false;
                    throw new InvalidCityNameException("Invalid City Name Please Enter valid Detail !!!");
                }
            }
            catch (InvalidCityNameException ex)
            {
                Console.WriteLine("Error  : " + ex.Message);
                return lContact;
            }
            Console.WriteLine("Enter state");
            string state = Console.ReadLine();
            try
            {
                if (!Regex.IsMatch(state, stateRegex))
                {
                    check = false;
                    throw new InvalidStateNameException("Invalid state Name Please Enter valid Detail !!!");
                }
            }
            catch (InvalidStateNameException ex)
            {
                Console.WriteLine("Error  : " + ex.Message);
                return lContact;
            }
            Console.WriteLine("Enter Zip");
            int zip = int.Parse(Console.ReadLine());
            try
            {
                if (!Regex.IsMatch(zip + "", zipRegex))
                {
                    check = false;
                    throw new InvalidZipException("Invalid Zip Please Enter valid Detail !!!");
                }
            }
            catch (InvalidZipException ex)
            {
                Console.WriteLine("Error  : " + ex.Message);
                return lContact;
            }
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Invalid Contact Address Detail: " + ex.Message);
            //}
            if (check == false)
            {
                Console.WriteLine("Please Enter correct AddressBook Details-----------------");
                return lContact;
            }
            foreach (var contact in lContact) {
                if (contact.FirstName.Equals(firstup) || contact.PhoneNo == phno
                     || contact.Email.Equals(email)){
                    cont = contact;
                    break;
                }
                else
                    Console.WriteLine("Contact Not present");
            }
            //  Contacts cont = lContact.Find(contact => contact.FirstName.Equals(firstup));
            if (cont != null)
            {
                cont.FirstName = first; cont.LastName = last; cont.PhoneNo = phno; cont.Email = email;
                cont.Address = address; cont.City = city; cont.State = state; cont.Zip = zip;
                Console.WriteLine("Contact Detail Updated");
            }
            return lContact;
        }
    }
}
