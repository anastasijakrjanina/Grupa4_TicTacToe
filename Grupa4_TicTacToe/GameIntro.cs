using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grupa4_TicTacToe
{
    internal class GameIntro
    {
        public static string HelloPlayer = "Hello, let's start the game!";

        public static void GameRules()
        {
            Console.WriteLine();
            Console.WriteLine("Game rules:");
            Console.WriteLine("1.Must be two players, choose your opponent");
            Console.WriteLine("2.Start player with symbol 'x' ");
            Console.WriteLine("3.Field cannot be overwriten");
            Console.WriteLine("4.Can't change move");
            Console.WriteLine("5.Winner is player who first set 3 same syimbols horizontaly/verticaly/diagonal");
            Console.WriteLine();
        }

        public static void GoodLuck()
        {

            Console.WriteLine("Good luck, player!");
            Console.WriteLine();
        }

        public static void Welcome()
        {
            Console.WriteLine("        GGGGGGGGGGGGG                                                                                 444444444");
            Console.WriteLine("     GGG::::::::::::G                                                                                4::::::::4");
            Console.WriteLine("   GG:::::::::::::::G                                                                               4:::::::::4");
            Console.WriteLine("  G:::::GGGGGGGG::::G                                                                              4::::44::::4");
            Console.WriteLine(" G:::::G       GGGGGGrrrrr   rrrrrrrrr      ooooooooooo   uuuuuu    uuuuuu ppppp   ppppppppp      4::::4 4::::4");
            Console.WriteLine("G:::::G              r::::rrr:::::::::r   oo:::::::::::oo u::::u    u::::u p::::ppp:::::::::p    4::::4  4::::4");
            Console.WriteLine("G:::::G              r:::::::::::::::::r o:::::::::::::::ou::::u    u::::u p:::::::::::::::::p  4::::4   4::::4");
            Console.WriteLine("G:::::G    GGGGGGGGGGrr::::::rrrrr::::::ro:::::ooooo:::::ou::::u    u::::u pp::::::ppppp::::::p4::::444444::::444");
            Console.WriteLine("G:::::G    G::::::::G r:::::r     r:::::ro::::o     o::::ou::::u    u::::u  p:::::p     p:::::p4::::::::::::::::4");
            Console.WriteLine("G:::::G    GGGGG::::G r:::::r     rrrrrrro::::o     o::::ou::::u    u::::u  p:::::p     p:::::p4444444444:::::444");
            Console.WriteLine("G:::::G        G::::G r:::::r            o::::o     o::::ou::::u    u::::u  p:::::p     p:::::p          4::::4");
            Console.WriteLine(" G:::::G       G::::G r:::::r            o::::o     o::::ou:::::uuuu:::::u  p:::::p    p::::::p          4::::4");
            Console.WriteLine("  G:::::GGGGGGGG::::G r:::::r            o:::::ooooo:::::ou:::::::::::::::uup:::::ppppp:::::::p          4::::4");
            Console.WriteLine("   GG:::::::::::::::G r:::::r            o:::::::::::::::o u:::::::::::::::up::::::::::::::::p         44::::::44");
            Console.WriteLine("     GGG::::::GGG:::G r:::::r             oo:::::::::::oo   uu::::::::uu:::up::::::::::::::pp          4::::::::4");
            Console.WriteLine("        GGGGGG   GGGG rrrrrrr               ooooooooooo       uuuuuuuu  uuuup::::::pppppppp            4444444444");
            Console.WriteLine("                                                                            p:::::p");
            Console.WriteLine("                                                                            p:::::p");
            Console.WriteLine("                                                                           p:::::::p");
            Console.WriteLine("                                                                           p:::::::p");
            Console.WriteLine("                                                                           p:::::::p");
            Console.WriteLine("                                                                           ppppppppp");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("TTTTTTTTTTTTTTTTTTTTTTT  iiii                      TTTTTTTTTTTTTTTTTTTTTTT                                   TTTTTTTTTTTTTTTTTTTTTTT");
            Console.WriteLine("T:::::::::::::::::::::T i::::i                     T:::::::::::::::::::::T                                   T:::::::::::::::::::::T");
            Console.WriteLine("T:::::::::::::::::::::T  iiii                      T:::::::::::::::::::::T                                   T:::::::::::::::::::::T");
            Console.WriteLine("T:::::TT:::::::TT:::::T                            T:::::TT:::::::TT:::::T                                   T:::::TT:::::::TT:::::T");
            Console.WriteLine("TTTTTT  T:::::T  TTTTTTiiiiiii     ccccccccccccccccTTTTTT  T:::::T  TTTTTTaaaaaaaaaaaaa      ccccccccccccccccTTTTTT  T:::::T  TTTTTTooooooooooo       eeeeeeeeeeee");
            Console.WriteLine("        T:::::T        i:::::i   cc:::::::::::::::c        T:::::T        a::::::::::::a   cc:::::::::::::::c        T:::::T      oo:::::::::::oo   ee::::::::::::ee");
            Console.WriteLine("        T:::::T         i::::i  c:::::::::::::::::c        T:::::T        aaaaaaaaa:::::a c:::::::::::::::::c        T:::::T     o:::::::::::::::o e::::::eeeee:::::ee");
            Console.WriteLine("        T:::::T         i::::i c:::::::cccccc:::::c        T:::::T                 a::::ac:::::::cccccc:::::c        T:::::T     o:::::ooooo:::::oe::::::e     e:::::e");
            Console.WriteLine("        T:::::T         i::::i c::::::c     ccccccc        T:::::T          aaaaaaa:::::ac::::::c     ccccccc        T:::::T     o::::o     o::::oe:::::::eeeee::::::e");
            Console.WriteLine("        T:::::T         i::::i c:::::c                     T:::::T        aa::::::::::::ac:::::c                     T:::::T     o::::o     o::::oe:::::::::::::::::e");
            Console.WriteLine("        T:::::T         i::::i c:::::c                     T:::::T       a::::aaaa::::::ac:::::c                     T:::::T     o::::o     o::::oe::::::eeeeeeeeeee");
            Console.WriteLine("        T:::::T         i::::i c::::::c     ccccccc        T:::::T      a::::a    a:::::ac::::::c     ccccccc        T:::::T     o::::o     o::::oe:::::::e");
            Console.WriteLine("      TT:::::::TT      i::::::ic:::::::cccccc:::::c      TT:::::::TT    a::::a    a:::::ac:::::::cccccc:::::c      TT:::::::TT   o:::::ooooo:::::oe::::::::e");
            Console.WriteLine("      T:::::::::T      i::::::i c:::::::::::::::::c      T:::::::::T    a:::::aaaa::::::a c:::::::::::::::::c      T:::::::::T   o:::::::::::::::o e::::::::eeeeeeee");
            Console.WriteLine("      T:::::::::T      i::::::i  cc:::::::::::::::c      T:::::::::T     a::::::::::aa:::a cc:::::::::::::::c      T:::::::::T    oo:::::::::::oo   ee:::::::::::::e");
            Console.WriteLine("      TTTTTTTTTTT      iiiiiiii    cccccccccccccccc      TTTTTTTTTTT      aaaaaaaaaa  aaaa   cccccccccccccccc      TTTTTTTTTTT      ooooooooooo       eeeeeeeeeeeeee");

        }

    }
}

