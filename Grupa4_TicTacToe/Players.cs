using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupa4_TicTacToe
{
    public class Players
    {
        public string Player1
        {
            get
            {
                Console.WriteLine();
                Console.WriteLine("Who is player 1. Enter your name:");
                Console.WriteLine();
                string player1 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(player1))
                {
                    Console.WriteLine("You did not enter your name");
                    Console.WriteLine("Try again.");

                    player1 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(player1))
                    {
                        Console.WriteLine("No more tries");
                    }
                    else
                    {
                        Console.WriteLine($"Your name is {player1}.");
                    }
                }
                else
                {
                    Console.WriteLine($"Your name is {player1}.");
                }
                return player1;
            }
        }


        public string Player2
        {
            get
            {
                Console.WriteLine();
                Console.WriteLine("Who is player 1. Enter your name:");
                Console.WriteLine();
                string player2 = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(player2))
                {
                    Console.WriteLine("You did not enter your name");
                    Console.WriteLine("Try again.");

                    player2 = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(player2))
                    {
                        Console.WriteLine("No more tries");
                    }
                    else
                    {
                        Console.WriteLine($"Your name is {player2}.");
                    }
                }
                else
                {
                    Console.WriteLine($"Your name is {player2}.");
                }
                return player2;
            }


        }

        public string Player3(string name)
        {
            Console.WriteLine();
            Console.WriteLine("Who is player 3. Enter your name:");
            Console.WriteLine();
            string name1 = Console.ReadLine();

        
            if (string.IsNullOrWhiteSpace(name))
            {
                {
                    Console.WriteLine($"Your name is {name}.");
                }
            }

            return name;
            }
        
    
}

