using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Practice
    {
       
        static void Main()
        {
            // Lesson: Using switch multiple-selection statement
            // Using a switch statement, count A, B, C, D and F grades
            int total = 0; // sum of grades
            int gradeCounter = 0; // number of grades entered
            int aCount = 0;
            int bCount = 0;
            int cCount = 0;
            int dCount = 0;
            int fCount = 0;

            Console.WriteLine("Enter integer grades in the range of 0-100.");
            Console.WriteLine("Type <Ctrl> z and press Enter to terminate input: ");

            string input = Console.ReadLine(); // read user input
                // loop until user enters the end-of-file indicator (<Ctrl> z)
            while (input != null) // if <Ctrl> z is entered while the program is awaiting input with a ReadLine method, NULL is returned!
            {
                int grade = int.Parse(input); // read grade from user input
                total += grade; // add grade to total
                ++gradeCounter; // increment number of grades
                
                // determine which grade was entered by user
                switch (grade / 10) // the switch expression performs integer division, which truncates the fractional part of the result, attempting to match thevalue of the switch expression with a case label
                {
                    case 10: // grade was 100 --No fall through in C# switch statement
                    case 9: // grade was 90s
                        ++aCount; // increment aCount
                        break; // exit switch
                    case 8: // grade was 80s
                        ++bCount;
                        break;
                    case 7: // grade was 70s
                        ++cCount;
                        break;
                    case 6: // grade was 60s
                        ++dCount;
                        break;
                    default: // grade was less than 60
                        ++fCount;
                        break;
                }
               
                input = Console.ReadLine(); // read user input
            }
            // if user entered at least one grade:
            if (gradeCounter != 0)
            {
                // calculate the average of all grades entered
                double average = (double)total / gradeCounter;

                // output summary of results
                Console.WriteLine($"Total of the {gradeCounter} grades entereed is {total}");
                Console.WriteLine($"Class average is {average:F}");
                Console.WriteLine($"Number of students who received each grade:");
                Console.WriteLine($"A: {aCount}");
                Console.WriteLine($"B: {bCount}");
                Console.WriteLine($"C: {cCount}");
                Console.WriteLine($"D: {dCount}");
                Console.WriteLine($"F: {fCount}");
            }
            else
            {
                Console.WriteLine("No grades were entered mister.......");
            }
        }
    }                        
}

/*
        // Lesson: Compound-Interest Calculations; Performing interest calculations with Math's static method Pow; Formatting with Field Widths and Alignment
        // Problem: A person invests $1,000 in a savings account yielding 5% interest. Assuming that all the interest is left on deposit,
        // calculate and print the amount of money in the account at the end of each year for 10 years. Use the following formula to determine 
        // the amounts:
        // Where 
        // p is the original amount invested(i.e., the principal)
        // r is the annual interest rate(e.g., use 0.05 for 5 %)
        // n is the number of years
        // a is the amount on deposit at the end of the nth year.

        decimal principal = 1000; // initial amount before interest
        double rate = 0.05; // interest rate

        // display heaers
        Console.WriteLine("Year Amount on deposit: ");

        // calculate amount on deposit for each of ten years
        for (int year = 1; year <= 10; ++year)
        {
            // calculate new amount for specified year
            decimal amount = principal * ((decimal)Math.Pow(1.0 + rate, year));
                        // Notes: Many classes provie methods to perform common tasks that do not require specific objects
                        // they must be called using a class name.  Such methods are called static methods, such as Console
                        // methods Write, WriteLine and ReadLine.  You call a static method by specifying the class name followed by
                        // the member-access operator (.) and the method name as in ClassName.MethodName(arguments).
                        // DO NOT USE FLOAT OR DOUBLE FOR MONETARY AMOUNTS!!!!!!!  Decimal for precise monetary representation and calc.

            // display the year and the amount
            Console.WriteLine($"{year,4}{amount,20:C}"); //Formatting with Field Widths and Alignment: field width of 4; right-aligned in a field of at least 20 characters (use negative field width for left-align)
        }
        */
/*
           // Lesson: Counter-controlled iteration with the for iteration statement

           // for statement header includes initialization, loop-continuation condition and increment
           for (int counter = 1; counter <= 10; ++counter)
           {
               Console.WriteLine($"{counter}");
           }
           // for statement header that iterates in decrements of 10
           for (int i = 100; i >= 0; i -= 10)
           {
               Console.WriteLine($"{i}");
           }
           */

/*
           // Lesson: Formulating Algorithms: Sentinel-Controlled Iteration; Top-Down, Stepwise Refinement
           // Develop a class-averaging app that processes rades for an arbitrary number of students each time it's run.
           // One way to solve this problem is to use a sentinel value (also called a signal value, a dummy value or a flag value) to indicate "end of data entry."
           // Sentinel-controlled iteration is often called indefinite iteration, because the number of iterations is not known before the loop begins execuing.

           // first refinement
           // Initialize variables
           // Input, sum and count the quize grades 
           // calculate and print the class average

           // second refinement
           // Initialize total to zero
           int total = 0;
           // Initialize counter to zero
           int gradeCounter = 0;
           // Prompt the user to enter the first grade
           Console.Write("Enter grade or -1 to quit: ");
           // Input the first grade (possibly the sentinel)
           int grade = int.Parse(Console.ReadLine());

           // While the user has not yet entered the esenitnel
           while (grade != -1)
           {
               // Add this grade into the running total
               total += grade;
               // Add one to the grade counter
               gradeCounter++;
               // Prompt the user to enter the next grade
               Console.Write("Enter grade or -1 to quit: ");
               // Input the next grade (possibly the sentinel)
               grade = int.Parse(Console.ReadLine());
           }
           // If the counter is not equal to zero
           if (gradeCounter != 0)
           {
               // Set the average to the total divided by the counter
               double average = (double) total / 10; // using a case operator "double" in this manner is called explicit conversion; compiler performs an operation called promotion (aka implicit conversion) on selected operands; average is initialized with the floating-point result.
               // Print the average
               Console.WriteLine($"The average grade is: {average}");
           }
           // Else 
           else
           {
               // Print "No grades were entered"
               Console.WriteLine("No grades were entered... Beep boop beep");
           }
           */
