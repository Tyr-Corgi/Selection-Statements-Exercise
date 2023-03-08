using System;

namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        
        {
            //Initializing and defining variables
            var r = new Random();
            var favNumber = r.Next(1, 1000);
            Console.WriteLine("Guess my Favorite Number");
            var userInput = int.Parse(Console.ReadLine());

            //Input Section

            
            var userGuess = userInput;

                //positive statement, userGuess matches "yes"
                if (userInput == favNumber)
            {
                Console.WriteLine("You are one in a thousand!");

            }
             
                //failure low
                else if (userInput < favNumber) 
            {
                Console.WriteLine("Wrong! Try again, you guessed too low");     
            }

                //failure high
                else if (userInput > favNumber)
            {
                Console.WriteLine("Wrong! Try again, you guessed too high");

            }



        }
    }
}
