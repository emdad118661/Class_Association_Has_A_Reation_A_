using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Association_Has_A_Reation_A_
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank ourBank = new Bank("Prime Bank", 5);
            Address address = new Address("Road no-10", "House no-58/A", "Dhaka", "Bangladesh");
            Account account1 = new Account();

            ourBank.AddAccount(account1);
            ourBank.PrintAccountDetails(20);
            ourBank.Transaction(account1);

            Console.WriteLine("*********************");
            Console.WriteLine("Address:"+address.GetAddress());
            Console.ReadKey();
        }
    }
}