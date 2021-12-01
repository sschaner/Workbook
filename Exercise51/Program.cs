using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise51
{
    class Program
    {
        /*
        * Exercise 51
        * Description:
        * Create a dictionary with the following key value pairs: hello => hola, food => comida, world => mundo,
        * computer => computadora, exercise => ejercicio.
        * Prompt the user to enter a word and output the translation.
        */
        static void Main(string[] args)
        {
            Console.Title = "Exercise 51";

            string userInput = "";
            bool enterAgain = true;
            Dictionary<string, string> translationDictionary = new Dictionary<string, string>();
            translationDictionary.Add("hello", "hola");
            translationDictionary.Add("food", "comida");
            translationDictionary.Add("world", "mundo");
            translationDictionary.Add("computer", "computadora");
            translationDictionary.Add("exercise", "ejercicio");

            do
            {
                Console.Write("Enter a word in English: ");
                userInput = Console.ReadLine();

                string translatedWord = TranslateFromEnglishToSpanish(translationDictionary, userInput);
                if (translatedWord.ToLower() != "not found")
                {
                    Console.WriteLine($"{userInput} in Spanish is {translatedWord}.");
                }
                else
                {
                    Console.WriteLine($"{userInput} cannot be translated.");
                }

                string continueInput = "";
                do // Loop for determining if the user wants to enter text again
                {
                    // Ask the user if they would like to continue
                    Console.Write("\nWould you like to continue (y/n)? ");
                    userInput = Console.ReadLine();
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

        // Takes user input and returns the Spanish translation or "not found"
        public static string TranslateFromEnglishToSpanish(Dictionary<string, string> translationDictionary, string userInput)
        {
            string translatedWord = "";

            if (translationDictionary.ContainsKey(userInput) == true)
            {
                foreach (var item in translationDictionary.Where(x => x.Key == userInput.Trim()))
                {
                    translatedWord = $"{item.Value}";
                }
            }
            else
            {
                translatedWord = "not found";
            }

            return translatedWord;
        }
    }
}
