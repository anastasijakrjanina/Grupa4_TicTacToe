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

HumanPlayer player1 = new HumanPlayer(); // izveidots objetkts
player1.GetPlayerName(); //izsaucam f-ciju GetPlayerName

HumanPlayer player2 = new HumanPlayer();
player2.GetPlayerName();


 
Console.WriteLine($"Player {player1.Name} is playing with {Symbol.X}");
 
Console.WriteLine($"Player {player2.Name} is playing with {Symbol.O}");
 
 
 
//Board started - addded 2022-06-06
//Need to add different conditions, and make a loop and maybe move to a separate class
 
string[] arr = new string[9] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
Board.ShowBoard(arr);
//Board1

 
Console.WriteLine($"Enter your value from 1 to 9: {player1.Name}");
int addedSymbol = int.Parse(Console.ReadLine());
arr[addedSymbol - 1] = "X";
Console.Clear();

Board.ShowBoard(arr);


//Board2

 
Console.WriteLine($"Enter your value from 1 to 9: {player2.Name}");
addedSymbol = int.Parse(Console.ReadLine());
arr[addedSymbol - 1] = "O";
Console.Clear();
//Board3
Board.ShowBoard(arr);

Console.WriteLine($"Enter your value from 1 to 9: {player1.Name}");
addedSymbol = int.Parse(Console.ReadLine());
arr[addedSymbol - 1] = "X";
Console.Clear();

Board.ShowBoard(arr);

//Board4
 
Console.WriteLine($"Enter your value from 1 to 9: {player2.Name}");
addedSymbol = int.Parse(Console.ReadLine());
arr[addedSymbol - 1] = "O";
Console.Clear();

Board.ShowBoard(arr);
//Board5
 
Console.WriteLine($"Enter your value from 1 to 9: {player1.Name}");
addedSymbol = int.Parse(Console.ReadLine());
arr[addedSymbol - 1] = "X";
Console.Clear();

Board.ShowBoard(arr);
//Board6
 
Console.WriteLine($"Enter your value from 1 to 9: {player2.Name}");
addedSymbol = int.Parse(Console.ReadLine());
arr[addedSymbol - 1] = "O";
Console.Clear();

Board.ShowBoard(arr);

//Board7
 
Console.WriteLine($"Enter your value from 1 to 9: {player1.Name}");
addedSymbol = int.Parse(Console.ReadLine());
arr[addedSymbol - 1] = "X";
Console.Clear();

Board.ShowBoard(arr);

//Board8
 
Console.WriteLine($"Enter your value from 1 to 9: {player2.Name}");
addedSymbol = int.Parse(Console.ReadLine());
arr[addedSymbol - 1] = "O";
Console.Clear();

Board.ShowBoard(arr);
//Board9
 
Console.WriteLine($"Enter your value from 1 to 9: {player1.Name}");
addedSymbol = int.Parse(Console.ReadLine());
arr[addedSymbol - 1] = "X";
Console.Clear();

/// Number is taken check needs to be added!!!!


if (arr[0] == arr[1] && arr[1] == arr[2])
{
    Console.WriteLine($"Congratulations {player1.Name}!");
    Console.WriteLine("You WON this game!");
}
else if (arr[3] == arr[4] && arr[4] == arr[5])
{
    Console.WriteLine($"Congratulations {player1.Name}!");
    Console.WriteLine("You WON this game!");
 
}
 
else if (arr[6] == arr[7] && arr[7] == arr[8])
{
    Console.WriteLine($"Congratulations {player1.Name}!");
    Console.WriteLine("You WON this game!");
 
}
else Console.WriteLine($"{player1.Name} YOU LOST THIS GAME!");
//Console.Clear();
 
//Board finished - addded 2022-06-06

