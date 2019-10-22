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
            // Lesson: Arrays II
            // multi-dimentional arrays

            // 2D array
            string[,] twoD;

            // 3D array
            string[,,] threeD;

            int[,] array2D = new int[,]
            {
                {1, 2, 3}, // row 0
                {4, 5, 6}, // row 1
                {7, 8, 9}  // row 2
            };
            Console.WriteLine("Middle value is {0}", array2D[1, 1]); // row 1, index 1
            Console.ReadKey();

            // 3D array
            string[,,] array3D = new string[,,]
            { // first dimention (Depth)
                { // second dimention (Height)
                    {"000", "001"}, // third dimention (Length)
                    {"010", "011"}
                },
                {
                    {"100", "101"},
                    {"110", "111"}
                }
            };
            Console.WriteLine("The value is {0}", array3D[1, 1, 0]); // entries are named exactly as required to access them.
            Console.ReadKey();

            // another way to create 2D array
            string[,] array2DString = new string[3, 2] // 3 rows and 2 indices per row
            { 
                { "one", "two" }, 
                { "three", "four" }, 
                { "five", "six" }
            };

            // update an indice 
            array2DString[0, 1] = "million";
            Console.WriteLine("The value is {0}", array2DString[0, 1]);
            Console.ReadKey();
        }
    }                        
}

/*
            // Lesson: Arrays
            // Arrays occupy space in memory. Since they're objects, they're typically created with keyword new.1 To create an array object, 
            // you specify the type and the number of array elements in an array-creation expression that uses keyword new and returns a reference
            // that can be stored in an array variable.
            // When you create an array with new, each element of the array receives the default value for the array's element type—0 for the numeric 
            // simple type elements, false for bool elements and null for references. 

            // create the space for an array and initialize to default (zeros)
            int[] array = new int[5]; // array contains 5 int elements
            // display index and values headings
            Console.WriteLine($"{"Index"}{"Value",8}"); // right-aligned with "8"

            // output each array element's value
            for (int counter = 0; counter < array.Length; ++counter)
            {
                Console.WriteLine($"{counter,5}{array[counter],8}");
            }

            //using an array initializer
            int[] myArray = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 }; // comma-seprated list of expressions (initializer list)
            Console.WriteLine("myArray values are: ");
            for (int counter = 0; counter < myArray.Length; ++counter)
            {
                Console.WriteLine($"{counter,5}{myArray[counter],8}");
            }

            int[] favNums = new int[5];
            favNums[0] = 5;
            favNums[1] = 67;
            favNums[2] = 27;
            favNums[3] = 55;
            favNums[4] = 96;

            Console.WriteLine("My favorite numbers are: ");
            for (int counter = 0; counter < favNums.Length; ++counter)
            {
                Console.WriteLine($"{counter,5}{favNums[counter],8}");
            }
            Console.ReadKey(); // Pauses for user's keystroke
            Console.WriteLine("What are your favorite numbers? ");
            for (int counter = 0; counter < favNums.Length; ++counter) {
                string input = Console.ReadLine();
                favNums[counter] = int.Parse(input);
                Console.WriteLine($"Favorite number {counter} is {input}");
            }
            // can also display the array list by: Console.WriteLine("Element{0} = {1}", counter, favNums[counter]);

            // Tip.....  CW then double tab to get Console.WriteLine()....... ... .
            // foreach loop
            string[] myFriends = { "Daniel", "Jerry", "Nick" };
            foreach (string name in myFriends)
            {
                Console.WriteLine("Hello {0}, my friend", name);
            }
            Console.ReadKey();
            */
// Lesson:  The .NET Framework Class Library 
// 'using' directives allow us to use library classes from the Framework Class Library without specifying their namespace names.  For
// example, an app would include the declaration 'using System;' in order to use the class names from the 'System' namespace without
// fully qualifying their names.  This allows you to use the 'unqualified' name 'Console', rather than the 'fully qualified' name
// 'System.Console', in code.

// Lesson: Few notes on Methods.
// ***Three ways to call a method.  1.) Using a method name by itself to call a method of the same class.
// 2.) Using a referene to an object followed by the member-access operator (.) and the method name to call a non-static method of
// the referenced object.  3.) Using the class name and the member-acess operator(.) to call a static method of a class.
// ***A static method or property can call only other statick methods or properties of the same class directly (i.e., using the method 
// name by itself) and can manipulate only static variables in the same class directly.  To access a class's non-static members, a 
// static method or property must use a reference to an object of that class.

// Lesson: Argument Promotion and Casting
/*
Type	Conversion types
*****bool	no possible implicit conversions to other simple types
byte	ushort, short, uint, int, ulong, long, decimal, float or double
char	ushort, int, uint, long, ulong, decimal, float or double
*****decimal	no possible implicit conversions to other simple types
*****double	no possible implicit conversions to other simple types
float	double
int	    long, decimal, float or double
long	decimal, float or double
sbyte	short, int, long, decimal, float or double
short	int, long, decimal, float or double
uint	ulong, long, decimal, float or double
ulong	decimal, float or double
ushort	uint, int, ulong, long, decimal, float or double
*/
// By default, C# does not allow you to implicitly convert values between simple types if the target type cannot represent every value
// of the original type (e.g., the int value 2000000 cannot be represented as a short, and any floating-pint number with nonzero digits
// after its decimal point cannot be represented in an integery type such as long, int or short.

/*
// Lesson: using continue statement to skip an iteration of a for statement
for (int count = 1; count <= 10; ++count) // loop 10 times
{
    if (count == 5) // if count is 5
    {
        continue; // skip remaining code in the loop
    }
    Console.WriteLine($"{count}");
}
*/
/*
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
          */
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
