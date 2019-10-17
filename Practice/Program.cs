using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");

            //---------------------------Arithmetic---------------------------------//

            // displaying the sum of two numbers
            int number1; // declare first number to add
            int number2; // declare second number to add
            int sum; // declare sum of number1 and number2

            Console.Write("Enter first integer: "); // prompt user
            // read first number from user
            number1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second integer: "); // prompt user
            // read second number from user
            number2 = int.Parse(Console.ReadLine());

            // add numbers and assign to 'sum'
            sum = number1 + number2;

            // print out the sum
            Console.WriteLine($"Sum is {sum}"); // using string interpolation

            // arithmetic mean(average) of five terms
            int m = 0, a = 2, b = 4, c = 6, d = 8, e = 10; // declare vars
            // display indication for calculating mean
            Console.WriteLine("Displaying the mean of 2 + 4 + 6 + 8 + 10");
            m = (a + b + c + d + e) / 5;

            // print out the mean
            Console.WriteLine($"Mean is {m}");

            //---------------------------Equality & Relational Operators---------------------------------//

            // display equality of number1 and number2
            if (number1 == number2)
            {
                Console.WriteLine($"{number1} equals {number2}");
            }
            else
            {
                Console.WriteLine($"{number1} (your entry for number1) does not equal {number2} (your entry for number2)");
            }

            // display if number1 is less than or equal to number2
            if (number1 <= number2)
            {
                Console.WriteLine($"{number1} is less than or equal to {number2}");
            }
            else
            {
                Console.WriteLine($"{number1} is not less than or equal to {number2}");
            }

                                 
        }
    }
}
