using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Account //lesson: classes with a blance; procesing monetary amounts
    {
        // instance variables
        public string Name { get; set; }
        private decimal balance;

        // constructor

        public Account(string accountName, decimal initialBalance)
        {
            Name = accountName;
            balance = initialBalance; // Balance's set accessor validates
        }

        // properties


        public decimal Balance
        {
            get
            {
                return balance;
            }
            private set // can only be used within the class
            {
                // validate that the balance is greater than 0.0; if it's not, instance variable balance keeps its prior value
                if (value > 0.0m) // m indicates that 0.0 is a decimal literal !!!!!!!!!!!!!!!!
                {
                    balance = value;
                }
            }
        }
        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m) // if the depositAmount is valid
            {
                // Balance = Balance + depositAmount; // add it to the balance
                balance += depositAmount; // using compound assignment instead
            }
        }
        /*private string name; // instance variable

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value; // remember that value is a keyword only in a property's context
            }
                 
        }*/
    }
}
