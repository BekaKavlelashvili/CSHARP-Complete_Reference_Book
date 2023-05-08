using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Constraint
{
    class NotFoundException : Exception
    {
        public NotFoundException() : base() { }
        public NotFoundException(string message) : base(message) { }
        public NotFoundException(string message, Exception innerException) : base(message, innerException) { }
        protected NotFoundException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

    public interface IPhoneNumber
    {
        string Name { get; set; }
        string Number { get; set; }
    }

    class Friend : IPhoneNumber
    {
        public bool IsWorkNumber { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }

        public Friend(string n, string num, bool wk)
        {
            Name = n;
            Number = num;
            IsWorkNumber = wk;
        }
    }

    class Supplier : IPhoneNumber
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public Supplier(string name, string number)
        {
            Name = name;
            Number = number;
        }
    }

    class EmailFriend { }

    class PhoneList<T> where T : IPhoneNumber
    {
        T[] pList;
        int end;

        public PhoneList()
        {
            pList = new T[10];
            end = 0;
        }

        public bool Add(T newEntry)
        {
            if (end == 10)
                return false;

            pList[end] = newEntry;
            end++;

            return true;
        }

        public T FindByName(string name)
        {
            for (int i = 0; i < end; i++)
            {
                if (pList[i].Name == name)
                    return pList[i];
            }

            throw new NotFoundException();
        }

        public T FindByNumber(string num)
        {
            for (int i = 0; i < end; i++)
            {
                if (pList[i].Number == num)
                    return pList[i];
            }

            throw new NotFoundException();
        }
    }

    public static class InterfaceConstraint
    {
        public static void InterfaceConstraintMain()
        {
            Console.WriteLine("\n=== Interface Constraint ===");

            PhoneList<Friend> phoneList = new PhoneList<Friend>();
            phoneList.Add(new Friend("Tom", "555-1234", true));
            phoneList.Add(new Friend("Gary", "555-6756", true));
            phoneList.Add(new Friend("Matt", "555-9254", false));

            try
            {
                Friend frnd = phoneList.FindByName("Gary");
                Console.WriteLine(frnd.Name + ": " + frnd.Number);

                if (frnd.IsWorkNumber)
                    Console.WriteLine(" (work)");
                else
                    Console.WriteLine();
            }
            catch (NotFoundException)
            {
                Console.WriteLine("Not Found");
            }

            Console.WriteLine();

            PhoneList<Supplier> phoneList2 = new PhoneList<Supplier>();
            phoneList2.Add(new Supplier("Global Hardware", "555-8834"));
            phoneList2.Add(new Supplier("Computer Warehouse", "555-9256"));
            phoneList2.Add(new Supplier("NetworkCity", "555-2564"));

            try
            {
                Supplier sp = phoneList2.FindByNumber("555-2564");
                Console.WriteLine(sp.Name + ": " + sp.Number);
            }
            catch (NotFoundException)
            {
                Console.WriteLine("Not Found");
            }

            Console.WriteLine();

            //this eill be error becouse EmailFriend doesn't implement IPhoneNumber
            //PhoneList<EmailFriend> emFrnd = new PhoneList<EmailFriend>();

        }
    }
}
