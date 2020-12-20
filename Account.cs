using Class_Association_Has_A_Reation_A_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Account
    {
        private int accountNumber=20;
        private string accountName="Shakib", email="shakib75@gmail.com";
        private double balance=1000.0;
        private double amount=100.0;
        private Address Address;
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }
        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public double Amount
        {
            set { this.amount = value; }
            get { return this.amount; }
        } 
        public void Deposit(double amount)
        {
            this.balance += amount;
            Console.WriteLine("Deposit successfull.Your Current Balance:"+balance);
        }
        public void Withdraw(double amount)
        {
            if (balance>=amount)
            {
                this.balance -= amount;
                Console.WriteLine("Withdraw successfull.Your Current Balance:"+balance);
            }
            else
                Console.WriteLine("You do not have sufficient balance");
        }
        public void Transfer(double amount,Account account)
        {
            if (balance >= amount)
            {
                this.balance -= amount;
                account.balance += amount;
                Console.WriteLine("Transfered Successfully! Your current balance:"+this.balance);
            }
            else
                Console.WriteLine("You do not have sufficient balance");
        }
        public void ShowAccountInfo()
        {
           Console.WriteLine("Account No:{0} \n Account Name:{1} \n Email:{2} \n Balance:{3}",AccountNumber,AccountName,Email,Balance);
        }

    }
}