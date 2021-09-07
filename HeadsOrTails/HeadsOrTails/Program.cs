using System;

namespace HeadsOrTails
{
    class Program
    {
        private static void Main(string[] args)
        {
            do
            {
                HeadsOrTails();
                Console.WriteLine();
                AskAgain();
            } while (true);
        }

        private static void HeadsOrTails()
        {
            Console.ForegroundColor = ConsoleColor.White;
            int tails = 0;
            int heads = 0;
            Random rnd = new Random();

            Console.WriteLine("Heads or Tails!");
            int flips = 0;

            do
            {
                try
                {
                    Console.WriteLine();
                    Console.Write("Please enter a number of flips: ");
                    flips = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine();
                    Console.WriteLine("The input MUST be an ODD number!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();
                }

                if (flips < 0 || flips > 9999)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The input must be between 1 and 9999!");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (flips % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The input MUST be an ODD number!");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }

                else
                {
                    for (int i = 0; i < flips; i++)
                    {
                        int random = rnd.Next(0, 100);
                        if (random % 2 == 0)
                        {
                            heads++;
                        }
                        else
                        {
                            tails++;
                        }
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Tails - {tails} | Heads - {heads}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine();

                    if (tails > heads)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Tails has won with {tails} flips!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (heads > tails)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine($"Heads has won with {heads} flips!");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
            } while (flips % 2 == 0 || flips > 9999 || flips < 0);
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
