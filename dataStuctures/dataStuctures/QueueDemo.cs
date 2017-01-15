using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace dataStuctures
{
    struct BankCustomer
    {
        internal string name;
        internal string bankingActivity;
        internal int accountNum;
        internal float amnt;
    }

    enum BankingActivity
    {
        Deposit, Withdrawal, TransferFunds
    }

    class QueueDemo
    {
        //Create a customerr 
        private BankCustomer localBankCustomer;
        //Create the queue
        Queue localBankQueue = new Queue();

        public void QueueCustomers() {
            // The customers come in one at a time and get in line
            // Waiting for the first teller to show up

            // The first customer

            localBankCustomer.name = "J. P. Morgan";
            localBankCustomer.bankingActivity = BankingActivity.Deposit.ToString();
            localBankCustomer.accountNum = 12345;
            localBankCustomer.amnt = 1510.00F;

            localBankQueue.Enqueue(localBankCustomer);

            // The second customer

            localBankCustomer.name = "John Cena";
            localBankCustomer.bankingActivity = BankingActivity.TransferFunds.ToString();
            localBankCustomer.accountNum = 66698;
            localBankCustomer.amnt = 1510.00F;

            localBankQueue.Enqueue(localBankCustomer);

            // The third customer

            localBankCustomer.name = "Cena John";
            localBankCustomer.bankingActivity = BankingActivity.Withdrawal.ToString();
            localBankCustomer.accountNum = 6666;
            localBankCustomer.amnt = 1510.00F;

            localBankQueue.Enqueue(localBankCustomer);

            //See how many people are in the line 
            Console.WriteLine("\nCount of items in the queue at the start: {0}", localBankQueue.Count.ToString());
            Console.WriteLine("\n");

            //now we want to remove items from the queue so we can work on them
            //the items are an object so we need to recognize that
            //put the queue data in the localbankCustomers

            localBankCustomer = (BankCustomer)
            localBankQueue.Dequeue();

            //Write out
            Console.WriteLine("Name: \t\t"+localBankCustomer.name);
            Console.WriteLine("Activity: \t" + localBankCustomer.bankingActivity);
            Console.WriteLine("Acount #: \t" + localBankCustomer.accountNum);
            Console.WriteLine("Amount: \t" + localBankCustomer.amnt);

            Console.WriteLine("\nCount of items in the queue: {0}", localBankQueue.Count.ToString());
            Console.WriteLine("\n");

            do {
                localBankCustomer = (BankCustomer)
                localBankQueue.Dequeue();

                //Write out
                Console.WriteLine("Name: \t\t" + localBankCustomer.name);
                Console.WriteLine("Activity: \t" + localBankCustomer.bankingActivity);
                Console.WriteLine("Acount #: \t" + localBankCustomer.accountNum);
                Console.WriteLine("Amount: \t" + localBankCustomer.amnt);

                Console.WriteLine("\nCount of items in the queue: {0}", localBankQueue.Count.ToString());
                Console.WriteLine("\n");

            } while (localBankQueue.Count!=0);
        }
    }
}
