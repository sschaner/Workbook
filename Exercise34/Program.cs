using System;

namespace Exercise34
{
    /*
     * Exercise 34
     * 
     * Description:
     * Create an array of size 5 with the following numbers: 16, 32, 64, 128, 256
     * Prompt the user to enter a command, 'half' or 'double'.
     * If the user enters 'half', half all the elements in the array.
     * If the user enters 'double', double all the elements in the array.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercise 34";

            int[] numbersArray = new int[] { 16, 32, 64, 128, 256 };
            string messageStart = "The array now contains";

            bool enterAgain = false;
            do // Loops as long as the user wants to continue
            {
                Console.Write("Enter a command (half/double): ");
                string halfOrDouble = Console.ReadLine();

                if (halfOrDouble.ToLower().Trim() == "half")
                {
                    numbersArray = (HalfElementsInArray(numbersArray));
                    Console.WriteLine($"{messageStart} {string.Join(", ", numbersArray)}.");
                }

                if (halfOrDouble.ToLower().Trim() == "double")
                {
                    numbersArray = (DoubleElementsInArray(numbersArray));
                    Console.WriteLine($"{messageStart} {string.Join(", ", numbersArray)}.");
                }

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

        // Method that returns the half of each element in an array
        public static int[] HalfElementsInArray (int[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = numbersArray[i] / 2;
            }
            
            return numbersArray;
        }

        // Method that returns the double of each element in an array
        public static int[] DoubleElementsInArray(int[] numbersArray)
        {
            for (int i = 0; i < numbersArray.Length; i++)
            {
                numbersArray[i] = numbersArray[i] * 2;
            }

            return numbersArray;
        }

    }
}
