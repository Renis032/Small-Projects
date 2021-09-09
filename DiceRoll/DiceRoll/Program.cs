using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiceRoll
{
    class Program
    {
        private static void Main(string[] args)
        {
            DiceRoll();
        }

        static void DiceRoll()
        {
            Console.WriteLine("Press any key to roll the dice.");
            Random rnd = new Random();
            int playerWins = 0;
            int AIWins = 0;

            do
            {
                int playerRoll = rnd.Next(1, 7);
                int AIRoll = rnd.Next(1, 7);

                Console.ReadKey();
                Console.WriteLine("You rolled: " + playerRoll);
                Console.WriteLine("-----");
                
                Thread.Sleep(500);
                Console.WriteLine("The enemy rolled: " + AIRoll);
                if (playerRoll > AIRoll)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You win!");
                    Console.ForegroundColor = ConsoleColor.White;
                    playerWins++;
                }
                else if (AIRoll > playerRoll)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("The enemy wins this round!");
                    Console.ForegroundColor = ConsoleColor.White;
                    AIWins++;
                }
                else if (playerRoll == AIRoll)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Draw!");
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine($"Score - Player: {playerWins} | Enemy: {AIWins}\n");
                Console.WriteLine("Press any key to play again\n\n\n\n");
            } while (true);
        }
    }
}
