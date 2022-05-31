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

        //vai 1 spēlētājs eksistē  ?
        public bool GetIsNameentered()
        {
            return !string.IsNullOrWhiteSpace(Person1);
        }

        //vai 1 spēlētājs eksistē  ?
        public static bool IsPlayer1NameExist(string Person1)
        {

            return !string.IsNullOrWhiteSpace(Person1);

      
        }

        public string Person2 { get; set; }
        //vai 2 spēlētājs eksistē  ?
        public static bool IsPlayer2NameExist(string Person2)
        {
            return !string.IsNullOrWhiteSpace(Person2);
        }
        //spēli sāk spēlētājs ar simbolu X


    }
}



    
    


