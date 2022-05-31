using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupa4_TicTacToe
{
       
    public class Players
    {
        public string Person1{ get; set; }

       

        public void Player1Name()
        {
            Console.WriteLine($"{Person1}");
        }

        //vai 1 spēlētājs eksistē  ?
        public bool GetIsNameentered()
        {
            return !string.IsNullOrWhiteSpace(Person1);
        }

        //vai 1 spēlētājs eksistē  ?
        public static bool IsPlayer1NameExist(string Person1)
        {

            return !string.IsNullOrWhiteSpace(Person1);

            // bool check = string.IsNullOrWhiteSpace(Person1);



            //if ( !check)
            // {
            //     return "True";
            // }


            //return "False";

        }


        public string Person2 { get; set; }
        //vai 2 spēlētājs eksistē  ?
        public static bool IsPlayer2NameExist(string Person2)
        {
            return !string.IsNullOrWhiteSpace(Person2);
        }
        //spēli sāk spēlētājs ar simbolu X


        //public static string StartsPlayerWithSymbolX(bool symbol)
        //{
        //    bool symbol = X
        //    if 
        //        {
        //        return "Start game";
        //    }
        //    return "You are second";
        //}

        //public static bool IsPlayer1NameExist()
        //{
        //    if (IsPlayer1NameExist())
        //    {
        //        return true;
        //    }
        //    return false;
        //}
        //public void Player1Name()
        //{
        //    Console.WriteLine();
        //    Console.Write("Player 1, please enter Your name:");
        //    Console.WriteLine();
        //    string Player1 = Console.ReadLine();

        //    if (string.IsNullOrWhiteSpace(Player1))
        //    {
        //        Console.WriteLine("You did not enter your name. Try again.");

        //        Player1 = Console.ReadLine();

        //        if (string.IsNullOrWhiteSpace(Player1))
        //        {

        //            Console.WriteLine("No more tries");

        //        }
        //        else
        //        {
        //            Console.WriteLine($"Your name is {Player1}.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Your name is {Player1}.");
        //    }

        //}


        public void Player2Name()
        {
            Console.WriteLine();
            Console.WriteLine("Who is player 2. Enter your name:");
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

        }

    }
}



    
    


