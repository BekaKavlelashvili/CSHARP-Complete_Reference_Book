using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Account
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public double Balance { get; private set; }

        public string AccountNumber { get; private set; }

        public Account(string firstName, string lastName,  string accountNum, double balance)
        {
            FirstName = firstName;
            LastName = lastName;
            AccountNumber = accountNum;
            Balance = balance;
        }
    }

    public class DemonstrateOrderBy
    {
        public static void DemonstrateOrderByMain()
        {
            Console.WriteLine("\n=== Demonstrate OrderBy ===");

            Account[] accounts = { new Account("Tom", "Smith", "132CK", 100.23),
                new Account("Tom", "Smith", "132CD", 10000.00),
                new Account("Ralph", "Jones", "436CD", 1923.85),
                new Account("Ralph", "Jones", "454MM", 987.132),
                new Account("Ted", "Krammer", "897CD", 3223.19),
                new Account("Ralph", "Jones", "434CK", -123.32),
                new Account("Sara", "Smith", "543MM", 5017.40),
                new Account("Sara", "Smith", "547CD", 34955.79),
                new Account("Sara", "Smith", "843CK", 345.00),
                new Account("Albert", "Smith", "445CK", 213.67),
                new Account("Betty", "Krammer","968MM",5146.67),
                new Account("Carl", "Smith", "078CD", 15345.99),
                new Account("Jenny", "Jones", "108CK", 10.98)
            };

            var accInfo = from info in accounts
                          orderby info.LastName, info.FirstName, info.Balance
                          select info;

            Console.WriteLine("Accounts in sorted order: ");
            string str = string.Empty;

            foreach (Account acc in accounts)
            {
                if(str != acc.FirstName)
                {
                    Console.WriteLine();
                    str = acc.FirstName;
                }

                Console.WriteLine("{0}, {1}\tAcc#: {2}, {3,10:C}", acc.LastName, acc.FirstName, acc.AccountNumber, acc.Balance);
            }

            Console.WriteLine();
        }
    }
}
