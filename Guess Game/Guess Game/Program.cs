
using System;

namespace Guess_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                string secretWord = "Daktari";
                string guess = "";
                int guessCount = 0;
                int guessLimit = 3;
                bool outOfGuesses = false;

                while (guess != secretWord && !outOfGuesses)
                {
                    if (guessCount < guessLimit)
                    {
                        Console.Write("Enter guess: ");
                        guess = Console.ReadLine();
                        guessCount++;
                    }
                    else
                    {
                        outOfGuesses = true;
                    }

                }
                if (outOfGuesses)
                {
                    Console.WriteLine("You lose!");
                }
                else
                {
                    Console.WriteLine("You win!");
                }

                Console.Write("Play again? (yes/no): ");
                string playChoice = Console.ReadLine().ToLower();

                Console.Clear();
                if (playChoice != "yes")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadLine();
        }
    }
}

