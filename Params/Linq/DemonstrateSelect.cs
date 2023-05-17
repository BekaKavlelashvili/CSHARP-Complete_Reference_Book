using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class ContactInfo
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ContactInfo(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
        }
    }

    class EmailAddress
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public EmailAddress(string name, string address)
        {
            Name = name;
            Address = address;
        }

    }

    public class DemonstrateSelect
    {
        static void EmailAddressSelect()
        {
            Console.WriteLine("\n=== Select a portion of a range variable ===");

            EmailAddress[] addrs = {
                new EmailAddress("Herb", "Herb@HerbSchildt.com"),
                new EmailAddress("Tom", "Tom@HerbSchildt.com"),
                new EmailAddress("Sara", "Sara@HerbSchildt.com")
            };

            var eAddrs = from n in addrs
                         select n.Address;

            Console.WriteLine("The e-mail addresses are: ");
            foreach (string item in eAddrs)
                Console.WriteLine(" " + item);
        }

        static void ContactInfoSelect()
        {
            Console.WriteLine("\n=== Select another type of object from other type range variable ===");

            ContactInfo[] contacts = {
                 new ContactInfo("Herb", "Herb@HerbSchildt.com", "555-1010"),
                 new ContactInfo("Tom", "Tom@HerbSchildt.com", "555-1101"),
                 new ContactInfo("Sara", "Sara@HerbSchildt.com", "555-0110")
             };

            var emailList = from n in contacts
                            select new EmailAddress(n.Name, n.Email);

            Console.WriteLine("The e-main list is: ");

            foreach (EmailAddress item in emailList)
                Console.WriteLine(" {0}: {1}", item.Name, item.Address);
        }

        static void SimpleSelect()
        {
            Console.WriteLine("\n=== Select square root ===");

            double[] nums = { -10.0, 16.4, 12.125, 100.85, -2.2, 25.25, -3.5 };

            var sqrRts = from n in nums
                         where n > 0
                         select Math.Sqrt(n);

            Console.WriteLine("The square roots of the positive values" + " rounded to two decimal places:");

            foreach (double item in sqrRts)
                Console.WriteLine("{0:#.##}", item);

        }

        public static void DemonstrateSelectMain()
        {
            SimpleSelect();
            EmailAddressSelect();
            ContactInfoSelect();
        }
    }
}
