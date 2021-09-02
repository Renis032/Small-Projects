using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(60, 20);
            Console.SetBufferSize(80, 80);
            bool again = true;
            do
            {
                NumberGuess();
                Console.WriteLine();
                AskAgain();
            } while (again);

        }
        static void NumberGuess()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Random rnd = new Random();
            int random = rnd.Next(0, 20);
            Console.WriteLine("Guess the number!");
            Console.WriteLine();
            bool game = true;

            int tries = 5;
            Console.WriteLine("Tries: " + tries);
            do
            {
                Console.WriteLine();
                Console.Write("Please enter a number to guess: ");
                int n = Int32.Parse(Console.ReadLine());
                if (random == n)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Correct! You guessed the number! The number was: {random}!");
                    Console.BackgroundColor = ConsoleColor.Black;
                    game = false;
                }

                else if (random < n)
                {
                    tries--;
                    Console.WriteLine($"The number is less than {n}! \nTries left: {tries}");
                }
                else if (random > n)
                {
                    tries--;
                    if (tries > 0)
                    {
                        Console.WriteLine($"The number is greater than {n}! \nTries left: {tries}");
                    }
                }

                if (tries == 0)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("No tries left! The number was: " + random);
                    Console.BackgroundColor = ConsoleColor.Black;
                }
            } while (game && tries > 0);
        }

        static void AskAgain()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Play again? Y/N");

           
            bool correctInput = false;
            do
            {
                string playAgain = Console.ReadLine();
                if (playAgain.ToLower() == "y")
                {
                    Console.Clear();
                    correctInput = true;
                }
                else if (playAgain.ToLower() == "n")
                {
                    correctInput = true;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(0);
                }

                if (!correctInput)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The input must be 'Y' or 'N'! \nPlease enter the correct input!\n");
                    Console.ForegroundColor = ConsoleColor.Blue;
                }

            } while (!correctInput);
        }
    }
}
