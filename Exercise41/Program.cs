using System;

namespace Exercise41
{
    class Program
    {
        /*
        * Exercise 41
        * Description:
        * Prompt the user to enter two numbers.
        * Divide the two numbers and show only two decimal places.
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 41";

            bool enterAgain = true;

            do
            {
                // Prompt the user to enter two numbers
                Console.Write("Enter a number: ");
                double userNumberOne = double.Parse(Console.ReadLine());
                Console.Write("Enter another number: ");
                double userNumberTwo = double.Parse(Console.ReadLine());

                string message = DivideTwoNumbersMessage(userNumberOne, userNumberTwo);
                Console.WriteLine(message);

                string continueInput = "";
                do // Loop for determining if the user wants to enter text again
                {
                    // Ask the user if they would like to continue
                    Console.Write("\nWould you like to continue (y/n)? ");
                    string userInput = Console.ReadLine();
                    continueInput = userInput;
                    if (continueInput.ToLower().Trim() == "y")
                    {
                        enterAgain = true;
                    }
                    else if (continueInput.ToLower().Trim() == "n")
                    {
                        Console.WriteLine("Goodbye!");
                        enterAgain = false;
                        goto Exit;
                    }
                    else
                    {
                        Console.WriteLine("Please enter either 'y' or 'n'");
                    }
                } while (continueInput.ToLower().Trim() != "y");
            } while (enterAgain == true);

        Exit:

            Console.ReadKey();
        }

        public static string DivideTwoNumbersMessage(double userNumberOne, double userNumberTwo)
        {
            string message = "";
            if (userNumberTwo == 0)
            {
                message = "You cannot divide by 0.";
            }
            else
            {
                message = $"{Math.Round(userNumberOne / userNumberTwo, 2, MidpointRounding.AwayFromZero)}";
            }
            return message;
        }
    }
}
