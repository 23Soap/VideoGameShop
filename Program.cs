using System.IO;
namespace GameShop;

class Program
{
    static void Main(string[] args)
    {

        string filePath =
            "C:\\Users\\19yus\\OneDrive\\Masaüstü\\C# Basics\\GameShop\\GameShop\\VideoGames.txt";
        bool menu = true;
        bool playAgain = true;

        while (menu)
        {
            string answer;

            while (playAgain)
            {
                Console.WriteLine("1 - Add new Video Game");
                Console.WriteLine("2 - List current games");
                Console.WriteLine("3 - Item Numbers: ");
                Console.WriteLine("4 - Exit");
                
                string input = Console.ReadLine();
                randomNumbers randomNumsGenerator = new randomNumbers();

                if (input == "1")
                {

                    Console.WriteLine("Enter Game Name: ");
                    string itemName = Console.ReadLine();

                    Console.WriteLine("Enter Item Price: ");
                    string ItemPrice = Console.ReadLine();
                    Console.WriteLine("Enter Stock Number: ");
                    string stockNumber = Console.ReadLine();

                    int randomNumber = randomNumsGenerator.GenerateNumber(1000, 9999);

                    string addedGames = $"{randomNumber},{itemName},{ItemPrice},{stockNumber}\n";
                    File.AppendAllText(filePath, addedGames);
                    Console.WriteLine($"{addedGames}" + "==> Game added successfully");
                }

                else if (input == "2")
                {
                    if (File.Exists(filePath))
                    {
                        string[] allGames = File.ReadAllLines(filePath);
                        Console.WriteLine("\nGames: \n ");
                        foreach (var game in allGames)
                        {
                            Console.WriteLine(game);
                        }
                    }
                }else if (input == "3")
                {
                    if (File.Exists(filePath))
                    {
                        Console.WriteLine("Enter Item Number to search: ");
                        string itemNumberSearch = Console.ReadLine();
                            
                        string[] allGames = File.ReadAllLines(filePath);
                        bool gameFounded = false;

                        foreach (var game in allGames)
                        {
                            var gameDetails = game.Split(',');

                            if (gameDetails[0] == itemNumberSearch)
                            {
                                Console.WriteLine($"Game found:\nID: {gameDetails[0]}, Name: {gameDetails[1]}, Price: {gameDetails[2]}, Stock Number: {gameDetails[3]}");
                                gameFounded = true;
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Game not found");
                            }
                        }

                            
                    }else if (input == "4")
                    {
                        Console.WriteLine("Would you like to go back to menu? (Yes/No) ");
                        answer = Console.ReadLine();
                        answer = answer.ToUpper();

                        if (answer == "YES")
                        {
                            playAgain = true;
                            Console.WriteLine("Welcome Back!");
                        }
                        else
                        {
                            playAgain = false;
                            Console.WriteLine("Thanks for visiting");
                        }
                    }
                }   

                break;
            }

            
        }

        Console.ReadLine();
    }
}