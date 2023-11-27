using System;

// Namespace

namespace Quess_Numbers
{
    //Main class
    class Program
    {
        //entry point Method
        // project
        static void Main(string[] args)
        {
            getAppInfo(); //Run getAppInfo funtion to get info

            // run GetApp Functioon !!!

            GreetUser(); //Ask for users name and greet

            while (true)
            {

                // init correct number
                // int correctNumber = 6;

                // create a new Random object
                Random random = new Random();

                // init correct number
                int correctNumber = random.Next(1, 10);

                // init quess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //while quess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");

                        // keeping going
                        continue;
                    }


                    // cast to int and put in  Quess
                    guess = Int32.Parse(input);

                    // Match quess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong Number, Please try again");
                    }
                }
                // Print error message
                PrintColorMessage(ConsoleColor.Yellow, "Correct!!! you guested it!");

                // Ask to play again
                Console.WriteLine("Play Again? [y or N]");

                //get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else
                {
                    return;
                }
            }

        }

        //get and display appInfo
        static void getAppInfo()
        {
            // set app vars
            string appName = "Number Quesser";
            string appVersion = "1.0.0";
            string appAuthor = "Cleo Murphy";

            // change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // write out app info
            Console.WriteLine("{0}: version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // Ask user name and greet
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            //get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        // Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // change text color
            Console.ForegroundColor = color;

            // tell users it is the wrong number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }

    }
}
