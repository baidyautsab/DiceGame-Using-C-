using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DiceGame
{
    internal class DiceGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wellcome in the dice game");
            Console.WriteLine("Rules: There are 10 round, in every round dice will be rolled by clicking a key, at the end winner will be announced.");
            Console.WriteLine();
            Console.WriteLine();

            int playerDice, enemyDice;

            int playerScore = 0, enemyScore = 0;
            
            Random random = new Random();

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("===================================");
                Console.WriteLine("Round " + i);
                Console.WriteLine("Press any key to roll the dice...");

                Console.ReadKey();

                Console.Write("Rolling");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(".");
                    Thread.Sleep(500);
                }
                Console.WriteLine();

                playerDice = random.Next(1, 7);
                Console.WriteLine("You rolled a " + playerDice);

                // Thread.Sleep(1000);

                enemyDice = random.Next(1, 7);
                Console.WriteLine("Enemy rolled a " + enemyDice);

                if(enemyDice > playerDice)
                {
                    Console.WriteLine("Enemy won the round.");
                    enemyScore++;
                }
                else if(playerDice > enemyDice)
                {
                    Console.WriteLine("You won the round.");
                    playerScore++;
                }
                else
                    Console.WriteLine("Round Draw!");
                Console.WriteLine("===================================");
            }

            Console.WriteLine("Player Score: " + playerScore + "   Enemy Score: " + enemyScore);

            if (playerScore > enemyScore)
            {
                Console.WriteLine("Congratulations! You won the game.");
            }
            else if (playerScore < enemyScore)
            {
                Console.WriteLine("Sorry! Enemy won the game.");
            }
            else
            {
                Console.WriteLine("It's a draw!");
            }
        }
    }
}
