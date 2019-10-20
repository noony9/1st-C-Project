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
                double average = total / 10; // using a case operator "double" in this manner is called explicit conversion
                // Print the average
                Console.WriteLine($"The average grade is: {average}");
            }
            // Else 
            else
            {
                // Print "No grades were entered"
                Console.WriteLine("No grades were entered... Beep boop beep");
            }
            








        }
    }                        
}
