using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class AccountTest
    {
       
        static void Main() // Lesson: using properties rather than set and get methods
        {
            Account account1 = new Account("Jim Bob", 50.00m);
            Account account2 = new Account("Jane Bob", -7.53m);

            // display initial balance of each object
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance}");
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance}");

            // prompt for, read input, then deposit
            Console.Write("\nEnter deposit amount for account1: ");
            decimal depositAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Adding deposit to account1 balance\n");
            account1.Deposit(depositAmount); // add to account1's balance

            // prompt for, read input, then deposit
            Console.Write("\nEnter deposit amount for account2: ");
            depositAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Adding deposit to account2 balance\n");
            account2.Deposit(depositAmount); // add to account2's balance

            // display new balances
            Console.WriteLine($"{account1.Name}'s balance: {account1.Balance:C}"); // using a format specifier ":C"
            Console.WriteLine($"{account2.Name}'s balance: {account2.Balance:C}");

            /*
             // create an account object and assign it to myAccount
             Account myAccount = new Account("billy", 0.0m);

             // display myAccount's initial name (there isn't one yet)
             Console.WriteLine($"Initial name is: {myAccount.Name}");

             // prompt for and read the name, then put the name in the objet
             Console.Write("Enter the name: "); // prompt
             string theName = Console.ReadLine(); // read the name
             myAccount.Name = theName; // put theName in the myAccount object

             // display the name stored in the myAccount object
             Console.WriteLine($"myAccount's name is: {myAccount.Name}");
             */
        }
    }                        
}
