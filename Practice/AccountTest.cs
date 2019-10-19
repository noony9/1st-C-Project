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
            // create an account object and assign it to myAccount
            Account myAccount = new Account("billy");

            // display myAccount's initial name (there isn't one yet)
            Console.WriteLine($"Initial name is: {myAccount.Name}");

            // prompt for and read the name, then put the name in the objet
            Console.Write("Enter the name: "); // prompt
            string theName = Console.ReadLine(); // read the name
            myAccount.Name = theName; // put theName in the myAccount object

            // display the name stored in the myAccount object
            Console.WriteLine($"myAccount's name is: {myAccount.Name}");
        }
    }                        
}
