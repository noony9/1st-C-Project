using System;

namespace NumGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello C#");

            getAppInfo(); //Run function to display the application info and purpose

            getUserInfo();  //Run function to get user's name and ask if they want to play

            playGame(); // Run the game

        }

        // Display the application information and purpose
        static void getAppInfo()
        {
            //Initialize app variables
            string appName = "Num Guess";
            string appVersion = "1.0";
            string appAuthor = "Daniel Jacobs";

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            //Display app info
            Console.WriteLine("{0}, Version {1}, written by {2}", appName, appVersion, appAuthor);

            //Display app purpose
            Console.WriteLine("Num Guess is an extremely popular and hardcore game where the system prompts you to guess a number between 1 and 10!");
        }
        // Get users name and greet user
        static void getUserInfo()
        {
            //Ask users name
            Console.WriteLine("What is your name?");

            //Get user input
            string userInput = Console.ReadLine();

            //Display greetings
            Console.WriteLine("Greetings {0}, Let's play a game!)", userInput);
        }
        // Run the game
        static void playGame()
        {
            while (true)
            {

                //Generate a random number and assign it to the game's number
                Random random = new Random();
                int sysNumber = random.Next(1, 10);
                //User's initial guess
                int userGuess = 0;

                //Prompt user to guess a number between 1 and 10
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (userGuess != sysNumber)
                {
                    //Get user's input
                    string input = Console.ReadLine();

                    //Ensure user enters a number
                    if (!int.TryParse(input, out userGuess))
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                        //Inform user of error
                        Console.WriteLine("Error, not a number, please enter a valid number");

                        //Continue program
                        continue;
                    }
                    //Cast input to an integer and assign to userGuess
                    userGuess = Int32.Parse(input);

                    //Match the system number to the user's guess
                    if (userGuess != sysNumber)
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.DarkRed;

                        //Inform user of error
                        Console.WriteLine("Error, wrong number, please enter another value");
                    }

                }
                //Change text color
                Console.ForegroundColor = ConsoleColor.Green;

                //Inform user of correct answer
                Console.WriteLine("That is correct!!  I can't believe it!");

                //Change text color
                Console.ForegroundColor = ConsoleColor.White;

                //Ask user if they wish to play again
                Console.WriteLine("Do you wish to play again?  Enter \"YES\" or \"NO\"");

                //Ensure that user's response value works even if entered in lowercase
                string response = Console.ReadLine().ToUpper();

                //Continue the game if user indicates, exit if not or prompt again if user does not answer correctly
                if (response == "YES")
                {
                    continue;
                }
                else if (response == "NO")
                {
                    return;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
