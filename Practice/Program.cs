using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using C_Sharp_Practice;

namespace C_Sharp_Practice
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // Lesson:  Indexers
            var cookie = new HttpCookie();
            cookie["name"] = "Daniel";
            Console.WriteLine(cookie["name"]);
        }
    }
}
/*
    public class Person 
    {
        // shortcut:  prop then tab
        public string Name { get; set; }
        public string Username { get; set; }
        public DateTime Birthdate { get; private set; } // note access modifier added to set, which is readonly (set in the constructor instead)
        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        // auto implemented property

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Lesson: Properties
            // Writing setter and getter methods for every field would be time consuming and inefficient
            // Make sure your classes are in a valid state, never in a false state.
            var person = new Person(new DateTime(1982, 8, 16));
            Console.WriteLine(person.Birthdate);
        }
    }

/*
    public class Customer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Orders = new List<Order>();

        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        {
            this.Name = name;
        }

        public void Promote()
        {
            this.Name += " is a Legend";
        }
    }
    public class Order
    {

    }

    class Program 
    {
        static void Main(string[] args)
        {
            // Lesson: Fields
            var customer = new Customer(27);
            customer.Name = "Trevor";
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());
            Console.WriteLine(customer.Orders.Count);
            customer.Promote();
            Console.WriteLine("Customer's info: ID = {0}, Name = {1}", customer.Id, customer.Name);
        }
    }
/*
public class Point
{
    public int X;
    public int Y;

    public Point(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }
    public void Move(int x, int y)
    {
        this.X = x;
        this.Y = y;
    }

    public void Move(Point newLocation)
    {
        // to ensure to avoid exception if null value is entered
        if (newLocation == null)
            throw new ArgumentException("newLocation");

        // better way to implement this method
        Move(newLocation.X, newLocation.Y);
        /*
        this.X = newLocation.X;
        this.Y = newLocation.Y;
        */ /*
    }
}

public class Calculator
{
    public int Add(params int[] numbers)
    {
        var sum = 0;
        foreach (var number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}
public class Program
{
    static void Main(string[] args)
    {
        // Lesson: Methods
        var calculator = new Calculator();
        Console.WriteLine();
        Console.WriteLine(calculator.Add(1, 2));
        Console.WriteLine(calculator.Add(1, 2, 3, 4));
        Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6, 7 }));

    }
    static void UsePoints()
    {
        try
        {
            var point = new Point(10, 20);
            //point.Move(new Point(50, 100));
            point.Move(null);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            point.Move(200, 400);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
        }
        catch (Exception)
        {

            Console.WriteLine("An unexpected error occured.");
        }
    }
}
*/
           /*
            public class Order
            {

            }
            public class Customer
            {
                public int Id; // Remember, in Real World Applications we do not declare fields with public access modifiers...
                public string Name;
                public List<Order> orders; 
                public Customer() // as a best practice, when using a class and that class has a list of objects of any type, always initiaize that list an empty list
                {
                    orders = new List<Order>();       
                }

                public Customer(int id) 
                    : this() // When this constructor is called, first it will call the default constructor (Best practice to ensure the list gets initialized), instead of copying and pasting a bunch of code 
                {
                    this.Id = id;
                }

                public Customer(int id, string name) // snippet = ctor(tab)
                    : this(id) // When this constructor is called, first it will call the (int id) overload constructor
                {
                    this.Name = name;
                }
            }

            class Program
            {

                static void Main()
                {
                    // Constructors
                    // Do not have a return type, not even void
                    // Parameterless or "default" constructor.  If you do not define one, C# compiler creates one for it
                    // Example
                    /* 
                     * public class Customer
                     * {
                     *      public string Name;
                     *      public Customer(string name) 
                     *      {
                     *      this.Name name; // this references the current object.  
                     *      }
                     * }
                     */
           // Constructor Overloading
           // Same name, different signatures (return type, its name & types/numbers of it's parameters
           // the names do not matter but the data types and order of parameters matter
           // Why?  To make the initialization of the class easier.  Sometimes you may only know the name
           // sometimes you may know only the ID, etc.
           // Practice
           /*
           var customer = new Customer();
           Console.WriteLine(customer.Id);
           Console.WriteLine(customer.Name);

           customer.Name = "Phil";
           customer.Id = 8675309;
           Console.WriteLine(customer.Id);
           Console.WriteLine(customer.Name);

           customer.Id = 555;
           Console.WriteLine(customer.Id);

           }
           }
           */
           /*
              public class Person
              {
                  public string Name;
                  public void Introduce(string to)
                  {
                      Console.WriteLine("Hi {0}, I am {1}", to, Name);
                  }

                  // create a parse method
                  // have to use it on an object because it's an instance method
                  public static Person Parse(string str) // take a string and return a person object
                  {
                      var person = new Person();
                      person.Name = str;
                      return person;
                  }
              }
              class Program
              {
                 static void Main()
                  {
                      // Intro to classes
                      var person = new Person();
                      person.Name = "Daniel";
                      person.Introduce("Jimmy");
                      var p = Person.Parse("PurplePeopleEater");
                      Console.WriteLine(p.Name);

                  }
              }
              */
           /*
           static void Main()
           {

                      // Debugging Applications
                      // Debugging tools in Visual Studio
                      // How debugging works: 
                          // First you need to put 1 or more breakpoints in your application
                          // Run in debug mode.  Execution stops at your breakpoints.  There you can inspect the values of your
                          // variables to ensure they are holding the right value.  If not, you can change your code.
                          // Can insert a breakpoint by pressing 'F9' or remove it by pressing 'F9' again.
                          // F5 run in debug & Ctrl + F5 run without debug mode.
                          // F10 is step over, to move to the next line of code.
                          // F11 is step into

                      var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
                      var smallests = GetSmallests(numbers, 3);

                      foreach (var number in smallests)
                      {
                          Console.WriteLine(number);
                      }
                  }
                  public static List<int> GetSmallests(List<int> list, int count)
                  {
                      var smallests = new List<int>();
                      while (smallests.Count < count)
                      {
                          var min = GetSmallest(list);
                          smallests.Add(min);
                          list.Remove(min);
                      }
                      return smallests;
                  }
                  public static int GetSmallest(List<int> list)
                  {
                      // Assume the first number is the smallest
                      var min = list[0];
                      // Iterate over the list starting with index 1 through count
                      for (var i = 1; i < list.Count; i++)
                      {
                          if (list[i] > min)
                          {
                              min = list[i];
                          }
                          return min;
                      }
                  }
                  */
           /*
                       // Working with files and directories
                       // System.IO
                       // File, FileInfo
                       // Both provide methods for creating, copying, deleting and moving files
                       // File: provides static methods
                       // FileInfo: provides instance methods
                       // Why we need different classes for files: The difference is, if you are going to have a small
                       // number of operations, it's more conveienent to access the static methods of the file class,
                       // everytime you call static methods, some security checking is done by the operating system
                       // to ensure the user has access to these.  This can slow a program down with larger operations.
                       // With larger operations, use FileInfo as security checking is done once during creation of a FileInfo object.
                       // Some of the useful methods:
                       // Create() -create a file
                       // Copy()
                       // Delete()
                       // Exists() - check if a file exists
                       // GetAttributes() - returns the attributes of a given file
                       // Move()
                       // ReadAllText() - reads all text within a file          
                       // Directory, DirectoryInfo
                       // Very similar to File and FileInfo
                       // Directory provides static methods
                       // DirectoryInfo: provides instance methods
                       // Some of the useful methods:
                       // CreateDirectory()
                       // Delete()
                       // Exists()
                       // GetCurrentDirectory() -returns where the application is currently sitting
                       // GetFiles() -get files within a directory
                       // Move()
                       // GetLogicalDrives() -c-drive, d-drive etc.
                       // Path
                       // useful methods
                       // GetDirectoryname()
                       // GetFileName()
                       // GetExtension()
                       // GetTempPath() - returns the path of the current user's temp folder
                       /*
                       var path = @"c:\somefile.jpg"; // @ is verbatim symbol
                       File.Copy("c\\temp\\myfile.jpg", "d:\\temp\\myfile.jpg", true);
                       File.Delete(path);
                       if (File.Exists(path))
                       {
                           // something
                       }
                       var content = File.ReadAllText(path); // returns a string
                       var fileInfo = new FileInfo(path);
                       fileInfo.CopyTo("...");// copy the file
                       fileInfo.Delete();// delete it
                       if (fileInfo.Exists)
                       {
                           // something
                       }
                       // FileInfo does not have a ReadAllText method, only available as a static method in the File class
                       */
           // Directory and Directory Info classes
           /*
           Directory.CreateDirectory(@"c:\users\drjac\documents\github\files_practice\folder1");
           var files = Directory.GetFiles(@"c:\users\drjac\documents\github\files_practice", "*.txt", SearchOption.AllDirectories); // has 3 overloads
           foreach (var file in files)
           {
               Console.WriteLine(file);
           }

           var directories = Directory.GetDirectories(@"c:\users\drjac\documents\github\files_practice");

           var directoryInfo = new DirectoryInfo("...");
           directoryInfo.GetFiles();
           directoryInfo.GetDirectories();

           // Path class
           // provides a lot of methods to make it easy to work with a string that represents a path and extract different parts of that path
           // so we don't have to do the string processing ourselves
           // Example
           var path = @"c: \users\drjac\documents\github\files_practice\files_text.txt";
           // poor way to extract the extension using low level string processing
           var dotIndex = path.IndexOf('.'); // search for index of .
           var extension = path.Substring(dotIndex); // return extension
           // use path class instead
           Console.WriteLine("Extension: " + Path.GetExtension(path)); // get extension
           Console.WriteLine("File Name: " + Path.GetFileName(path)); // get file name
           Console.WriteLine($"File Name without Extension: {Path.GetFileNameWithoutExtension(path)}");
           // get directory name
           Console.WriteLine($"Directory Name: {Path.GetDirectoryName(path)}");
           */
           /*
                   static void Main()
                   {
                       // Procedural Programming
                       // You should always seperate the code that works with the console from code that implements logic
                       // With the many different types of applications, will want to be able to reuse code that is not part of the console
                       // Exercise
                       Console.WriteLine("What's your name? "); // console code
                       var name = Console.ReadLine(); // console code
                       var reversed = ReverseName(name);
                       Console.WriteLine("Reversed name: " + reversed); // console code
                            // the console is purely responsible for getting user input and displaying it
                   }
                   // extract the reusable code into a seperate method
                   public static string ReverseName(string name)// Need it public, in order to call it from main method (which is static) need it to be static, and need to return a string.  Method needs to be expressive in that others know what the method will do without looking at the code
                   {
                       // --------------- Reusable code
                       var array = new char[name.Length];
                       for (var i = name.Length; i > 0; i--)
                       {
                           array[name.Length - i] = name[i - 1];
                       }

                       return new string(array);
                       // ---------------- Reusable code 
                            // method is purely responsible for reversing the name
                   }
                   */
           /*
                       // Exercises
                       // Working with Text: exercise 3
                       // 3- Write a program and ask the user to enter a time value in the 24-hour time format (e.g. 19:00). 
                       // A valid time should be between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display
                       // "Invalid Time". If the user doesn't provide any values, consider it as invalid time.

                       Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 17:00): ");
                       var input = Console.ReadLine();

                       if (String.IsNullOrWhiteSpace(input))
                       {
                           Console.WriteLine("Invalid Time");
                           return;
                       }

                       var components = input.Split(':');
                       if (components.Length != 2)
                       {
                           Console.WriteLine("Invalid Time");
                           return;
                       }

                       try
                       {
                           var hour = Convert.ToInt32(components[0]);
                           var minute = Convert.ToInt32(components[1]);

                           if (hour >= 0 && hour <= 23 && minute >= 0 && minute <= 59)
                           {
                               Console.WriteLine("Ok");
                           }
                           else
                           {
                               Console.WriteLine("Invalid Time");
                           }
                       }
                       catch (Exception)
                       {
                           Console.WriteLine("Invalid Time");
                       }
                       */
           /*
           // 2- Write a program and ask the user to enter a few numbers separated by a hyphen. If the user simply 
           // presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are 
           // duplicates. If so, display "Duplicate" on the console.

           var inputList = new List<string>();

               Console.WriteLine("Enter a few numbers separated with a hyphen: ");
               string input = Console.ReadLine();
               inputList.Add(input);
               if (String.IsNullOrEmpty(input))
               {
                   return;
               }
               var numbers = new List<int>();
               foreach (var n in input.Split('-'))
               {
                   numbers.Add(Convert.ToInt32(n));
               }

               var uniques = new List<int>();
               var includesDuplicates = false;
               foreach (var n in numbers)
               {
                   if (!uniques.Contains(n))
                   {
                       uniques.Add(n);
                   }
                   else
                   {
                       includesDuplicates = true;
                       break;
                   }
               }
               if (includesDuplicates)
                   Console.WriteLine("Dulicate");
               */
           /*
           // 1- Write a program and ask the user to enter a few numbers separated by a hyphen. Work out if the 
           // numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a 
           // message: "Consecutive"; otherwise, display "Not Consecutive".

           // get input, place it in a string
           while (true)
           { 
               Console.WriteLine("Enter a few numbers separated with a hyphen: ");
               string input = Console.ReadLine();
               // check if string input is consecutive, if consecutive, output "Consecutive" then break loop.
               if (!input.Contains(" "))
               {
                   Console.WriteLine("Consecutive");
                   Console.ReadLine();
                   break;
               }  
               else
               {
                   Console.WriteLine("Not Consecutive");
               }
           }
           */
           /*
                       // Working with text: Closer look at C# Strings part 2
                       // StringBuilder
                       // A class that is defined in System.Text 
                       // Provides a number of different String Manipulation Methods
                       // Append(), Insert(), Remove(), Replace(), Clear()
                       var builder = new StringBuilder();
                       // append
                       builder.Append('-', 10); // dash character, repeated 10 times
                       Console.WriteLine(builder);
                       builder.AppendLine();
                       Console.WriteLine(builder);
                       builder.Append("Build");
                       Console.WriteLine(builder);
                       builder.Append(" " + "a" + " " + "Bridge");
                       Console.WriteLine(builder);
                       // builder.Replace('-', '+');
                       Console.WriteLine(builder);
                       builder.Insert(0, new string('!', 10));
                       Console.WriteLine(builder);
                       // *** Can chain them together, because they 'return' a StringBuilder
                       builder
                           .Append(" " + "as" + " fast" + " as" + " you" + " can")
                           .Remove(0, 20);
                       Console.WriteLine(builder); 
                       */
           /*
                        *  /*
                   public static string SummarizeText(string text) // could also allow the caller to specify the maxLength by making a second parameter
                                                                   // and setting a default value = 20, in case they don't want to specify            
                   {
                       // MUCH BETTER coding practice write a Constant (more expressive) instead of hardcoding a value all in the code
                       const int maxLength = 20;
                       if (text.Length < maxLength)
                       {
                           // Console.WriteLine(text);
                           return text;
                       }
                       // now to summarize the "poor way" then the "right way"

                       // May cutoff a word doing it with this kind of substringing
                       // text.Substring(0, maxLength); 
                       // how do we count the number of words that roughly fit around 20 characters
                       var words = text.Split(' '); // with whitespace as seperator, now we have a string array of words
                       // can iterate over the array, for each word, we count the length of the word, add them all together, if we get around 20 we should have a boundry
                       var totalCharacters = 0;
                       var summaryWords = new List<string>();
                       foreach (var word in words)
                       {
                           summaryWords.Add(word);
                           totalCharacters += word.Length + 1; // for each word, we need to get it's total characters + 1 for the space
                           if (totalCharacters > maxLength)
                               break;
                       }
                       // now, the summaryWords has all the words that need to go into the summary
                       // need to create a string and 'join' all these words using 'whitespace'
                       // var summary = String.Join(" ", summaryWords) + "..."; // First argument is a seperator, can pass summaryWords list and append "..." which will be the summary
                       //Console.WriteLine(summary); <--- Now that we are using it as a method, need to "return summary"
                       // return summary; <---- cleaning up code (see also var summary declaration)
                       return String.Join(" ", summaryWords) + "...";
                   }
                   */
           /*
               // Working with text: Closer look at C# Strings part 1
               var scentence = "This is a super, duper, incredibly long scentence, so it should be summarized. ";
               Console.WriteLine($"{SummarizeText(scentence)}"); 

               /*
                *
               // Summarizing Text ...
               var text = "This is a long, long, long, long, long, long, long scentence.";
               // summarize it
               // check if length of scentence is beyond a given threshold, otherwise display it
               if (text.Length < 20)
               {
                   Console.WriteLine(text);
               }
               // MUCH BETTER coding practice is to get rid of the '20' (magic number) and write a Constant (more expressive)
               const int maxLength = 20;
               if (text.Length < maxLength)
               {
                   Console.WriteLine(text);
               }
               // now to summarize the "poor way" then the "right way"
               else
               {
                   // May cutoff a word doing it with this kind of substringing
                   // text.Substring(0, maxLength); 
                   // how do we count the number of words that roughly fit around 20 characters
                   var words = text.Split(' '); // with whitespace as seperator, now we have a string array of words
                   // can iterate over the array, for each word, we count the length of the word, add them all together, if we get around 20 we should have a boundry
                   var totalCharacters = 0;
                   var summaryWords = new List<string>();
                   foreach (var word in words)
                   {
                       summaryWords.Add(word);
                       totalCharacters += word.Length + 1; // for each word, we need to get it's total characters + 1 for the space
                       if (totalCharacters > maxLength)
                           break;
                   }
                   // now, the summaryWords has all the words that need to go into the summary
                   // need to create a string and 'join' all these words using 'whitespace'
                   var summary = String.Join(" ", summaryWords) + "..."; // First argument is a seperator, can pass summaryWords list and append "..." which will be the summary
                   Console.WriteLine(summary);
               }
               */
           /*
           // Strings are a class and are immutable
           // Formatting:  
           // ToLower "hello world"
           // ToUpper "HELLO WORLD"
           // Trim() --very useful in eliminating the whitespaces around the string for user inputs in web forms or windows forms (ONLY from the end)
           // Searching:
           // Contains(" ")
           // IndexOf('a')
           // LastIndexOf("Hello")
           // Substrings: --create a substring from a given string
           // Substring(startIndex) retreives all the characters from that point to the end
           // Substring(startIndex, length)
           // Replacing: -- replace a given character or substring
           // Replace('a', '!')
           // Replace("hellow", "hello")
           // Null checking: -- common way to compare a string against null, empty or whitespace
           // String.IsNullOrEmpty(str)
           // String.IsNullOrWhiteSpace(str)
           // Splitting
           // str.Split(' ') -- splitting strings by delimenator
           // Converting Strings to Numbers
           // string s = "1234";
           // int i = int.Parse(s);
           // int j = Convert.ToInt32(s); // preferred.  If null or empty, returns default integer "0" / safer
           // Converting Numbers to Strings
           // int i = 1234;
           // string s = i.ToString(); = "1234"
           // string t = i.ToString("C"); = "$1,234.00" // "C" is a format string and that is short for currency.  by default when formatting a number by currency, contains 2 decimal points.
           // string t = i.ToString("C0"); = "$1,234" // C with zero decimal points.

           // Practice
           /*
           var fullName = "Daniel Jacobs    ";
           // trim
           fullName.Trim();
           Console.WriteLine(fullName);
           // ToUpper
           Console.WriteLine(fullName.ToUpper());
           Console.WriteLine(fullName); // note that it did not change the original string reference (immutable)
           // break name up into two parts by delimiter
           var index = fullName.IndexOf(' '); // can provide a character or a string here
           // split the string
           var firstName = fullName.Substring(0, index); // start of the string to index, which is the beginning of the space
           var lastName = fullName.Substring(index + 1); // using the first overload (one parameter) from index + 1 all the way to the end of the string
           Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}");
           // easier way to do it, using Split method
           string[] names = fullName.Split(' '); // if supply whitespace character, return type is a String Array
           Console.WriteLine($"First Name: {names[0]} Last Name: {names[1]}");
           // Replace method
           fullName.Replace("Daniel", "Jacobs");
           fullName.Replace("a", "z");
           Console.WriteLine($"Name with replacements: {fullName}"); // remember....  immutable.......
           Console.WriteLine($"Name with replacements, take two: {fullName.Replace("a", "z")}");
           // String Validation
           if (String.IsNullOrEmpty(" ")) // null or "" evaluates to true, but " " does not, but should if you were
                                         // evaluating a credit card number string for instance.  Requires a work-around
           {
               Console.WriteLine("Invalid");
           }
           if (String.IsNullOrEmpty(" ".Trim())) // trim the string first, OR in later versions, now has IsNullOrWhitespace
           {

           }
           if (String.IsNullOrWhiteSpace(" "))
           {
               Console.WriteLine("Invalid");
           }
           // we receive a number from a user, if building web, desktop or mobile applications (THEY ALWAYS COME IN STRINGS)
           // conversion
           var str = "25";
           var age = Convert.ToInt32(str); // immutable once again, have to place the modified string into a new object to store it.
           float price = 10.95f;
           price.ToString("C"); // EVERY OBJECT IN .NET HAS A ToString method (will cover later)
           Console.WriteLine($"{price}");
           */
           /*
                      // Working with Dates & Times and TimeSpan (Both these types are structures and are immutable)
                      // DateTime, defined in the system namespace
                      var dateTime = new DateTime(2019, 12, 1); // has a bunch of different constructor overloads
                      // get current DateTime
                      var now = DateTime.Now; // now is a static property of DateTime structure
                      var today = DateTime.Today; // today's date irrespective of time.
                      // example
                      Console.WriteLine("Hour: " + now.Hour); // or now.Minute for example
                      // DateTime objects are immutable (cannot change).
                      // All start with 'now"
                      // tomorrow, current time
                      var tomorrow = now.AddDays(1);
                      // formatting to a string.  Bunch of methods for formatting DateTime to strings
                      Console.WriteLine(now.ToLongDateString());
                      Console.WriteLine(now.ToShortDateString());
                      Console.WriteLine(now.ToLongTimeString());
                      Console.WriteLine(now.ToShortTimeString());
                      // Display both date and time!  use ToString method
                      Console.WriteLine(now.ToString("yyyy-MM-dd")); // can us other format specifiers "yy-MM-DD HH:mm" etc.  C# DateTime format specifiers on google

                      // TimeSpan
                      // Creating
                      var timeSpan = new TimeSpan(1, 2, 3); // overload: hours, minutes, seconds. There are many other overloads

                      var timeSpan1 = new TimeSpan(1, 0, 0); // looking at it, it's not obvious what the parameters represent
                      var timeSpan2 = TimeSpan.FromHours(1); // a more readable way to create the object is to use static methods on the TimeSpan structure (all start with 'From')

                      // another way to get a time span is to subtract an end from a start
                      var start = DateTime.Now;
                      var end = DateTime.Now.AddMinutes(2);
                      var duration = end - start;
                      Console.WriteLine($"Duration: {duration}");

                          // Once we have a TimeSpan object, we can read it's properties very easily
                          // Each TimeSpan has a number of properties that come in pairs (TotalDays, TotalHours etc.)
                      // Properties
                      Console.WriteLine($"Minutes: {timeSpan.Minutes} "); // returns the minutes component of the TimeSpan object
                      Console.WriteLine($"Total Minutes: {timeSpan.TotalMinutes}"); // converts that TimeSpan object to minutes (hours to minutes etc.)

                      // Add
                      Console.WriteLine($"Add Example: {timeSpan.Add(TimeSpan.FromMinutes(8))}");

                      // Conversion to and From Strings

                      // ToString
                      Console.WriteLine($"ToString {timeSpan.ToString()}"); // don't have to explicitly call ToString while using Console.WriteLine as it already does

                      // now conversion from a string.  Use Parse
                      Console.WriteLine($"Parse: {TimeSpan.Parse("01:02:03")}");
                      */
           /*
                       // Array Exercises

                       // 5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list
                       // is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
                       // the 3 smallest numbers in the list.
                           // declare a list to hold user entered strings
                       string[] numbers;
                           // prompt user
                       Console.WriteLine("Please enter a list of comma separated numbers and press \"Enter\" to exit: ");
                       // keep the loop going until user exits
                       while (true)
                       {
                           var entry = Console.ReadLine();

                           if (!String.IsNullOrWhiteSpace(entry))
                           {
                               numbers = entry.Split(',');
                               if (numbers.Length >= 5)
                               {
                                   break;
                               }
                           }
                           Console.WriteLine("Invalid List");
                       }
                       var numberList = new List<int>();
                       foreach (var n in numbers)
                       {
                           numberList.Add(Convert.ToInt32(n));
                       }
                       var smalliest = new List<int>();

                       while (smalliest.Count < 3)
                       {
                           var min = numberList[0];
                           foreach (var n in numberList)
                           {
                               if (n < min)
                               {
                                   min = n;
                               }
                           }
                           smalliest.Add(min);
                           numberList.Remove(min);
                       }
                       Console.WriteLine("The three smallest numbers are: ");
                       foreach (var n in smalliest)
                       {
                           Console.WriteLine(n);
                       }
                       */
           /*
           // Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
           // include duplicates. Display the unique numbers that the user has entered.
           var numbers = new List<int>();
           Console.WriteLine("Continuously enter numbers or type \"Quit\" to exit: ");
               // loop to continuously ask user to enter a number
           while (true)
           {
               var number = Console.ReadLine(); // get input, convert to int32
               if (number.ToLower() == "quit") // if user enters "Quit" exit the loop
               {
                   break;
               }
               // convert user inputs to int and add to numbers list
               numbers.Add(Convert.ToInt32(number));
           }
           // create new list to store unique user inputs
           var uniques = new List<int>();
           // iterate through numbers list
           foreach (var number in numbers)
           {
               if(!uniques.Contains(number)) // if unique, add to uniques list
               {
                   uniques.Add(number);
               }
           }
           Console.WriteLine($"Unique numbers entered are: ");
           foreach (var n in uniques)
           {
               Console.WriteLine(n);
           }
           Console.ReadLine();
           */

/*
// 3- Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display an error 
// message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the 
// result on the console.
var numbers = new List<int>();
Console.WriteLine("Enter 5 numbers: ");
while (numbers.Count < 5)
{
    var number = Convert.ToInt32(Console.ReadLine());
    if (numbers.Contains(number))
    {
        Console.WriteLine("You've already entered that number, please enter another: ");
        continue;
    }
    numbers.Add(number);
}
numbers.Sort();
Console.WriteLine("You entered: ");
foreach (var n in numbers)
{
    Console.Write($"{ n}, ");
}
*/
/*
// 2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the 
// result in a new string. Display the reversed name on the console.
Console.WriteLine("Please enter your name: ");
var name = Console.ReadLine();
var nameArray = new char[name.Length];
for (int i = nameArray.Length; i > 0; i--)
{
    nameArray[name.Length - i] = name[i - 1];
}
var reversed = new string(nameArray);
Console.WriteLine("Reversed name is: " + reversed);
*/

/*
1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays 
different information.
If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others 
like your post.
Write a program and continuously ask the user to enter different names, until the user presses Enter 
(without supplying a name). Depending on the number of names provided, display a message based on the above 
pattern.

var friendLikes = new List<string>();
while (true)
{
    Console.WriteLine("Type a name or hit enter to quit: ");
    var input = Console.ReadLine();
    if (String.IsNullOrWhiteSpace(input))
    {
        break;
    }
    friendLikes.Add(input);
}
if (friendLikes.Count == 1)
{
    Console.WriteLine($"{friendLikes[0]} likes your post");
}
else if (friendLikes.Count == 2)
{
    Console.WriteLine($"{friendLikes[0]} & {friendLikes[1]} like your post");
}
else if (friendLikes.Count > 2)
{
    Console.WriteLine($"{friendLikes.Count} people like your post!");
}
else
{
    Console.ReadLine();
}
*/
/*
            // Arrays and Lists

            // Lists
            // List is a generic type, can tell by <>

            var numbers = new List<int>() { 10, 80, 5, 2, 9 };
            // add 1 object to list
            numbers.Add(5);
            // add array to list
            numbers.AddRange(new int[] { 9, 8, 7, 2 });
            // iterate list
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            // IndexOf
            Console.WriteLine("index of 2 is: " + numbers.IndexOf(2));
            Console.WriteLine("Last of index of 2 is: " + numbers.LastIndexOf(2));
            // Count
            Console.WriteLine("Count: " + numbers.Count);
            // Remove
            numbers.Remove(80);
            foreach (var e in numbers)
            {
                Console.WriteLine(e);
            }
            // remove all instances of 2
            numbers.Remove(2);

            /*
           foreach (var e in numbers) // In C# we are NOT ALLOWED to MODIFY a COLLECTION USING FOREACH LOOP
           {
               if (e == 2)
               {
                   numbers.Remove(e);
               }
           }

           foreach (var e in numbers)
           {
               Console.WriteLine(e);
           }
           */
/*
 // use a for loop to modify a collection
 for (var i = 0; i < numbers.Count; i++)
 {
     if (i == 2)
     {
         numbers.Remove(i);
     }
 }
 foreach (var e in numbers)
 {
     Console.WriteLine(e);
 }
 // Clear()
 numbers.Clear();
 foreach(var e in numbers)
 {
     Console.WriteLine(e);
 }
 */
/*
// two types: single dimention and multi Dimention arrays(Rectangular -same number of columns in each row & Jagged -column length varies, a.k.a. array of arrays)

int[] numbers = new int[] { 8, 15, 2, 10 };

// Length
Console.WriteLine("Length: " + numbers.Length);
// IndexOf()
int index = Array.IndexOf(numbers, 3);
Console.WriteLine("Index of 3 is: " + index);
// Clear()
//Array.Clear(numbers, 0, 3);
// iterate with foreach to display elements
//foreach (var e in numbers)
// {
   // Console.WriteLine(e);
//  }
// Copy()
var array2 = new int[] { 9, 8, 7 };
Array.Copy(numbers, array2, 3);
foreach (var e in array2)
{
    Console.WriteLine(e);
}
// Sort()
Array.Sort(numbers);
foreach (var e in numbers)
{
    Console.WriteLine(e);
}
// Reverse()
Array.Reverse(numbers);
foreach (var e in numbers)
{
    Console.WriteLine(e);
}
*/
/*
            // Control Flow Exercises

            // 5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of the 
            // numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", the program should 
            // display 8.

            // Ask the user to enter a series of numbers separated by commas
            Console.WriteLine("Enter a series of numbers separated by commas then press enter: ");
            // get input and store it in a string variable
            var userInput = Console.ReadLine();
            // split user's input into a string array, delimeted by comma
            var numbers = userInput.Split(',');

            // declare and initialize an int variable to store max user input
            var max = Convert.ToInt32(numbers[0]);
            // loop through the full string array
            foreach (var str in numbers)
            {
                // declare a variable to hold the value at index and convert it to integer
                var number = Convert.ToInt32(str);
                // compare value at index with variable max, if greater, assign value at index to max
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"Max number of the values entered is: {max}");
            */


/*
// 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
// If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is 
// behaving correctly, you can display the secret number on the console first.)

// generate a random number between 1 and 10 and store it in variable secretNumber
var secretNumber = new Random().Next(1, 10);
// give the user 4 chances to guess the number by looping four times
int i = 0; // counter
while (true)
{
    ++i;
    // prompt user to enter a number
    Console.WriteLine("Guess a number between 1 and 10.  You have four chances: ");
    // get input and store in variable
    var userInput = Convert.ToInt32(Console.ReadLine());
    // display the secret number for testing
    Console.WriteLine(secretNumber);
    // if user guesses the number correctly, display "You won"; otherwisse display "You lost".
    if (userInput == secretNumber)
    {
        Console.WriteLine("You win");
        Console.ReadKey();
        break;
    }
    else if (i == 4)
    {
        Console.WriteLine("You lost");
        break;
    }   
}
*/

/*
// 2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the 
// previously entered numbers and display it on the console
int sum = 0; // declare a variable to hold sum of user entered integers
while (true)
{
    Console.WriteLine("Enter a number or \"ok\" to exit");
    string userInput = Console.ReadLine();
    if (userInput.ToLower() == "ok")
    {
        break;
    }
    sum += Convert.ToInt32(userInput);
}
Console.WriteLine(sum);
*/

/*// 1 - Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display 
// the count on the console.
int total = 0; // variable to hold the count
for (int i = 1; i < 100; i++)
{
    if (i%3 == 0)
    {
        ++total;
    }
}
Console.WriteLine(total); 
*/
/*
           // Control Flow: iteration, for, foreach, while and random class
           // Foreach loops: used to iterate over elements of an innumerable(definition: too many to be counted) object (list or array nature)

           // Random Class
           var random = new Random();

           const int passwordLength = 10; // declaring a constant so code is cleaner and easier to maintain

           var buffer = new char[passwordLength];
           for (int i = 0; i < passwordLength; i++)
           {
               buffer[i] = (char)('a' + random.Next(0, 26));
           }
           var password = new string(buffer); // better way than var password = ""; and can created it initialize it with 'buffer' array
           Console.WriteLine(password);


           /* var random = new Random();
           // generate a few random numbers and display them on the console
           for (int i = 0; i < 10; i++)
           {
               Console.WriteLine(random.Next());
               Console.WriteLine(random.Next(1, 10)); // parameters as range: min and max values

           }
           */
/*
var numbers = new int[] { 1, 2, 3, 4 };
foreach (int number in numbers)
{
    Console.WriteLine(number);
}
*/
/*
string name = "John Smith";
// iterate over the string and display new character on a new line
for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine(name[i]);
}
// now with foreach
foreach (var character in name)
{
    Console.WriteLine(character);
}
*/
/* Loop Demo
for (int i = 1; i <= 10; i++)
{
    // check the remainder of division of i by 2
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
// reverse
for (int i = 10; i >= 1; i--)
{
    if (i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}
*/
/*
 * // Exercises
                     // 1.) Write a program that asks user to enter a number between 1 and 10.
                     Console.WriteLine("Please enter an integer between 1 and 10.");
                     int userEntry = Int32.Parse(Console.ReadLine());
                     // test parse
                     // Console.WriteLine(userEntry + 5);

                     // If the user enters a valid number, display "Valid" on the console. Otherwise 
                     // display "Invalid" (This logic is used a lot in applications where values entered into input boxes need validated.
                     if (userEntry > 0 && userEntry < 11)
                     {
                         Console.WriteLine("Valid");
                     }
                     else
                     {
                         Console.WriteLine("Invalid");
                     }
         */
/*
    public static string LandscapeOrPortrait(int length, int width)
        {
            if (length >= 12 && width <= 8)
            {
                return ("Portrait");
            }
            else
            {
                return ("Landscape");
            }
            
        }
        
// 2.) Write a program and ask the user to enter the width and height of an image.  
Console.WriteLine("Enter the length and width in inches of a picture of your choice: ");
 int userInput1 = Int32.Parse(Console.ReadLine());
 int userInput2 = Int32.Parse(Console.ReadLine());
 // test parse
 // Console.WriteLine(userInput1 * 10 + userInput2);

 // Then tell if the image is landscape or portrait.
 Console.WriteLine(LandscapeOrPortrait(userInput1, userInput2));
 */
/*
            // 3.) Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, 
            // sensors, etc and focus purely on the logic. 

            // Write a program that asks the user to enter the speed limit. 
            Console.WriteLine("Enter the local speed limit in km/hr: ");
            int speedLimit = Int32.Parse(Console.ReadLine());

            // Once set, the program asks for the speed of a car in km/hr. 
            Console.WriteLine("Enter the speed you are going in km/hr: ");
            int currentSpeed = Int32.Parse(Console.ReadLine());

            // If the user enters a value less than the speed limit, program should display Ok on the console. 
            if (currentSpeed <= speedLimit)
            {
                Console.WriteLine("OK");
            }

            // If the value is above the speed limit, the program should calculate the number of demerit points.
            else if (currentSpeed > speedLimit)
            {
                int overSpeed = currentSpeed - speedLimit; // declare variable to hold the different in speed (to be used for loop condition)

                // For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
                // If the number of demerit points is above 12, the program should display License Suspended.
                switch (overSpeed)
                {
                    case int n when n >= 5 && n < 10:
                        Console.WriteLine("You've received 1 demerit point!");
                        break;
                    case int n when n >= 10 && n < 12:
                        Console.WriteLine("You've received 2 demerit points!");
                        break;
                    case int n when n >= 12:
                        Console.WriteLine("Your license is suspended!!");
                        break;
                    default:
                        break;
                }

            }
            */
/*
            bool isGoldCustomer = true;
            
            /*float price;
            if (isGoldCustomer)
            {
                price = 19.95f;
            }
            else
            {
                price = 29.95f;
            } 
// rewrite using conditional operator
float price = (isGoldCustomer) ? 19.95f : 29.95f;
Console.WriteLine(price);

            /*
            int hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else
            {
                Console.WriteLine("It's evening.");
            }
            Console.ReadLine();
            */
/*
public class Person
{
    public int Age;
}

     int number = 1; // this variable with the scope of the Main() method and the parameter in method Increment() are in two places in memory
            Increment(number); // when method is called that new location is created called number, incremented by 10 then immediately destroyed....

            // now look at a reference type
            Person person = new Person() { Age = 20 };
            MakeOld(person); // note that this parameter is not going to be copied, but referenced, so it will be changed.
            Console.WriteLine($"person's age = {person.Age}");

     public static void Increment(int number) // scope of number here is limited to the Increment method
        {
            number += 10;
        }
        
        public static void MakeOld(Person person) //this object and the one in main passed into the function will be referencing the object on the heap
        {
            person.Age += 10;
        }
    */

/*
            // Reference Types and Value Types
            // in C# there are 2 main types from which we create new types:  Classes and Structures
            // Structures are value type (allocated on stack; allocated automaticaly; immediately removed when out of scope)
            // Classes are reference type (allocated on heap; you need to allocate memory "new" compiler allocates to heap at runtime; garbage collected by CLR)

            // copying value types and reference types in action
            int a = 10;
            int b = a;
            b++;
            // what will value of a be at this point?  It is 10 still.
            // when you copy of value is stored in another variable, only a COPY of it is stored, original unmodified on the stack

            // now lets do reference
            var array1 = new int[3] { 1, 2, 3 }; // First an object created on heap at a memory location with address an array with three elements, next CLR creates a variable on stack named array1 with memory address of array on the heap.
            var array2 = array1; // Second, runtime creates a variable on the stack identified as array2 with memory address to the object array on the heap.
            // when we make any changes on the object on the heap, either through array1 or array2, it's changes are visible on either, that's why it is called reference.
            array2[0] = 0; // 
            Console.WriteLine(array1[0]);
            */
/*
   // Enum practice

            // declare an enum at the namespace level becaue it's a new type
        public enum ShippingMethod // best practices are to assign values during declaration
        {
            RegularAirMail = 1,
            RegisteredAirMail = 2,
            Express = 3
        }
        // Enum: A set of name/value pairs (constants) -use: instead of declaring multiple constants, declare an enum.
        // An Enum is internally an integer, can specify another type in declaration.

        // use enum
        var method = ShippingMethod.Express;
            Console.WriteLine(method);
            // cast it to an integer "should see 3"
            Console.WriteLine((int)method);
            // convert an integer to a ShippingMethod
            var methodID = 3;
            Console.WriteLine((ShippingMethod)methodID);
            // convert a string variable to an enum (Parse the String)
            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        */
/*
           // Create Strings, Characters and Verbatim Strings

           // concatenation
           string firstName = "Tim";
           string lastName = "Robbins";
           string name = firstName + " " + lastName;

           // use string format
           string favoriteNumber1 = "five";
           string favoriteNumber2 = "fifteen";
           string favoriteNumbers = string.Format("{0} {1}", favoriteNumber1, favoriteNumber2); // Format is a static method
           Console.WriteLine(favoriteNumbers);

           // use string join
           var numbers = new int[3] { 1, 2, 3 };
           // combine the three integers seperated by a comma
           string list = string.Join(",", numbers);
           Console.WriteLine(list);

           // Strings are immutable, once created you cannot change it.  There are methods in the string class that allow you to manipulate strings and modify their values, but the methods return a new string.
           // Common escape characters:  \n New Line, \t Tab, \\ Backslash, \' Single Quote, \" Double Quote
           // Verbatim Strings

               // example: string path = "c:\\projects\\project1\\folder1"; --looks messy
               // can use: string path = @"c:\projects\project1\folder1";
           */

// Non-Primitive Types: classes
/*
           Person timmy = new Person();
           timmy.FirstName = "Timmy";
           timmy.LastName = "Smith";
           timmy.Introduce();

           // declare a new GenericCalculator object then print it's value (sum)
           GenericCalculator gencalc = new GenericCalculator();

           // use object's inherited Add method to add two numbers
           int result = gencalc.Add(5, 5);
           Console.WriteLine($"Result is: {result}");

           // prompt user to input two integers to be added
           Console.WriteLine("User, please enter two integers to be added together: ");

           // read user entered string, convert to int32 and store in variables userEntry1 and userEntry2 respectively
           int userEntry1 = Convert.ToInt32(Console.ReadLine());
           int userEntry2 = Convert.ToInt32(Console.ReadLine());

           // use gencalc's inherited Add method to sum the numbers and assign the calculated result into userResult
           int userResult = gencalc.Add(userEntry1, userEntry2);

           // output the result
           Console.WriteLine($"Result is: {userResult}");
           */
/*
    public class Person // access modifier 'public'
    {
        public string Name;  // variables called fields capitalize these in classes
        public int Age;
        Person() { } // default constructor
        Person(string name, int age) // constructor
        {
            string Name = name;
            int Age = age;
        }
        public int Add(int a, int b) // methods
        {
            return a + b;
        }
        Person person = new Person("Jim", 20); // creating object - in C# classes are treated differently from primative types, must allocate memory to them.
                                               // also has garbage collecting for unused classes    
    }
    */
/*
            try
            {
                string number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number coult not be converted to a byte.");
            }
           */
/* implicit type conversion

           // explicit type conversion
           /*
           float f = 1.0f;
           int i = (int)f; // we are aware of the data loss, but use casting to cast float to int.
           */

// non compatible types
/*
string s = "1";
int i = Convert.ToInt32(s);
int j = int.Parse(s);
Console.WriteLine($"{s}{i}{j}");
*/

// variables and constants
/*
Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
const float Pi = 3.14f; // cannot modify
*/

/*
byte number = 2;
Console.WriteLine(number);

int count = 10;
float totalPrice = 20.95f; // tell the compiler explicitly that we want a float by appending an f at the end
char character = 'A';
string firstName = "Mosh";
bool isWorking = true;

Console.WriteLine(number);
Console.WriteLine($"{count}{character}{firstName}{isWorking}");
*/

// Overflowing
/*
byte number = 255;
number += number; // 0 when compiled, exceeded the boundry of the data type

// use the checked keyword
checked
{
    byte number = 255;
    number += number;
}
*/

/*
          // Lesson: Rectangular Arrays
          int[,] rectArray =
          {
              {1, 2, 3},
              {4, 5, 6}
          };
          // loop through array rows
          for (var row = 0; row < rectArray.GetLength(0); ++row) // get length of the first dimention = GetLength(0)
          {
              // loop through columns of current row
              for (var column = 0; column < rectArray.GetLength(1); ++column)
              {
                  Console.WriteLine($"{rectArray[row, column]}");
              }
          }
          */
// Lesson: Jagged Arrays

// declare a jagged array ---multiple arrays within an array
/* int[][] jaggedArray = new int[3][];
 jaggedArray[0] = new int[5];
 jaggedArray[1] = new int[3];
 jaggedArray[2] = new int[2];

 // initilize jaggedArray
 jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
 jaggedArray[1] = new int[] { 6, 7, 8 };
 jaggedArray[2] = new int[] { 9, 10 };

 // alternatively declare and initialize
 int[][] jagArray = new int[][]
 {
     new int[] { 10, 20, 30 },
     new int[] { 40, 50 },
     new int[] { 60 }
 };

 // accessing in jagged array
 // access middle element of first row
 Console.WriteLine($"{jagArray[0][1]}");
 Console.ReadLine();

 // output jagged array
 foreach (var row in jagArray)
 {
      // loop through each element in current row
      foreach (var element in row)
     {
         Console.WriteLine($"{element}");
     }
 } */
/*
           // Lesson: create an array of friends
           // create a foreach loop that greets all of them

           string[] myFriends = { "Nick", "Kevin", "Glenn", "Jim", "Brad" }; // create and initialize string array
           foreach (string name in myFriends)
           {
               Console.WriteLine("Greetings {0}", name);
           }

           // Lesson: Passing Arrays and Array Elements to Methods

           // create and initialize array with 5 values
           int[] array = { 1, 2, 3, 4, 5 };

           Console.WriteLine("Effects of passing reference to entire array:");
           Console.WriteLine("The values of the original array are:");

           // output original array elements
           foreach (var value in array)
           {
               Console.WriteLine($" {value}");
           }
           Console.ReadKey();
           /*
           // pass array reference
           ModifyArray(array);

           // output modified array elements
           foreach (var value in array)
           {
               Console.WriteLine($" {value}");
           }
           Console.WriteLine("Adding 10 to the elements in the array...");
           AddTenToArray(array);

           Console.WriteLine("Outputting array elements...");
           OutputIntArray(array);

           // methods outside of main()----
           static void AddTenToArray(int[] array2)
           {
               for (int i = 0; i < array2.Length; i++)
               {
                   array2[i] = array2[i] + 10;
                   //Console.WriteLine($"{array2[i]}");
               }
           }
           static void OutputIntArray(int[] array)
           {
               foreach (int value in array)
               {
                   Console.WriteLine($"{value}");
               }
           }
           */
/*
           // Lesson: more on arrays
           // myArray.Rank; will indicate how many dimentions an array is
           // correct declaration of an integer array that contains three rows and five columns:
           // Int[,] myArray = new int[3,5];

           // initialize loop
           int[] nums = new int[10];

           // populate array
           for (int i = 0; i < nums.Length; i++)
           {
               nums[i] = i;
           }
           // output original array elements
           for (int j = 0; j < nums.Length; j++)
           {
               Console.WriteLine("Element{0} = {1}", j, nums[j]);
           }
           Console.ReadKey();

           // use foreach loop to output original array elements
           foreach (int value in nums)
           {
               Console.WriteLine($"Element {0} is {1}", nums, value);
           }
           //SPECIAL NOTES:  
           // Limitations of foreach Loop: 
           // 1. Foreach loops are not appropriate when you want to MODIFY the ARRAY "foreach(int num in array) -only changes num not the array element
           // 2. Foreach loops do NOT KEEP TRACK of INDEX.  So you cannot obtain array index using foreach loop
           // 3. Foreach loops ONLY ITERATES FOWARD over the array in SINGLE STEPS.  Cannot iterate backwards
           */
/* // Lesson: Arrays II
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
    */
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
