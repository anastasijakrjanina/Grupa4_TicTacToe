//1. Noteikt dalībnieku skaitu un tipu:
//spēlētāju skaits 2 :
//spēlētāju tips:
// game with friend  // labāk uztaisīt tikai vienu no sākuma, piemēram, cilvēks pret cilvēku
// -random player
// -computer

//2.izvēlas simbolu // good to have // Labāk uzreiz ņemt default X, bez izvēles
//
//spēlētājs izvēlas spēles simboliu (X vai O)
//


//3.Izvēlas *spēles līmeņi - viegls (3x3)

//4. Spēles noteikumi
//4.1 Sāk spēlētājs ar simbolu X, var veikt tikai vienu gājiemu viena reizē, gājiens pāriet nākošajam spēlētājam
//4.2 Izdarīto gājienu nedrīkst mainīt
//4.3 Nedrīkst izmantot jau aizpildītu lauciņu
//4.4 uzvar spelētājs , kurš pirmais savāc 3 savus simbolus vai nu horizontāli, vai vertikāli, vai pa diognāli
//4.5 Apsveic uzvarētāju

//5. Spēle beigusies
//5.1 Sākt jaunu spēli vai turpināt ar to pašu spēlētāju (ja turpina ar to pašu spēlētāju, var izvēlēties simbolu)

//
//


//kā saukt lauciņus:
//A1 etc, 1-9, xrinda y kolonna


using Grupa4_TicTacToe;
string helloPlayer = GameIntro.HelloPlayer;
Console.WriteLine(helloPlayer);

GameIntro.GameRules();


GameIntro.GoodLuck();

Players players = new Players();


Console.WriteLine();
Console.Write("Player 1, please enter Your name:");
Console.WriteLine();
players.Person1 = Console.ReadLine();

if (string.IsNullOrWhiteSpace(players.Person1))
{
    Console.WriteLine("You did not enter your name. Try again.");
    players.Person1 = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(players.Person1))
    {
        Console.WriteLine("No more tries");

    }
    else
    {
        Console.WriteLine($"Hi {players.Person1}.");
    }
}
else
{
    Console.WriteLine($"Hi {players.Person1}.");
}


Console.WriteLine();
Console.Write("Player 2, please enter Your name:");
Console.WriteLine();
players.Person2 = Console.ReadLine();

if (string.IsNullOrWhiteSpace(players.Person2))
{
    Console.WriteLine("You did not enter your name. Try again.");

    players.Person2 = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(players.Person2))
    {
        Console.WriteLine("No more tries");

    }
    else
    {
        Console.WriteLine($"Your name is {players.Person2}.");
    }
}
else
{
    Console.WriteLine($"Your name is {players.Person2}.");
}

Console.WriteLine($"Player {players.Person1} is playing with {Symbol.X}");

Console.WriteLine($"Player {players.Person2} is playing with {Symbol.O}");