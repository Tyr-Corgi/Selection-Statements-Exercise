using System;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initializing and defining variables
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            int userInput;
            bool guessedCorrectly = false;

            // Loop until the user correctly guesses the number
            while (!guessedCorrectly)
            {
                // Prompt the user to guess the number
                Console.WriteLine("Guess my Favorite Number");

                // Read the user's input and handle invalid input
                if (!int.TryParse(Console.ReadLine(), out userInput))
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue;
                }

                // Compare the user's guess to the target number and provide feedback
                if (userInput == favNumber)
                {
                    Console.WriteLine("You are one in a thousand!");
                    guessedCorrectly = true;
                }
                else if (userInput < favNumber)
                {
                    Console.WriteLine("Wrong! Try again, you guessed too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Wrong! Try again, you guessed too high");
                }
            }

            // Wait for user input before closing the program
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
