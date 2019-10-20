using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class ClassAverage
    {
       
        static void Main()
        {
            // Lesson: class average, using counter-controlled iteration
            // Psedocode algorithm with counter-controlled iteration
                /* Set total to zero
                   Set grade counter to 1
                   While grade counter is less than or equal to 10 (students)
                       prompt the user to enter the next grade
                       input the next grade
                       add the grade into the total
                       add one to the grade counter
                   Set the class average to the total divided by 10
                   Display the class average */

            // initialization
            int total = 0; // initialize sum of grades entered by the user
            int gradeCounter = 1; // initialize grade # to be entered next

            // processing phase uses counter-controlled iteration
            while (gradeCounter <= 10)
            {
                Console.Write("Enter Grade: "); // prompt user
                int grade = int.Parse(Console.ReadLine()); // input grade
                total += grade; // add the grade total
                gradeCounter++;
            }

            // termination phase
            int average = total / 10; // integer division yeilds integer result

            // display total and average of rades
            Console.WriteLine($"\nTotal of all 10 grades is { total }");
            Console.WriteLine($"Class average is {average}");
        
            
        }
    }                        
}
