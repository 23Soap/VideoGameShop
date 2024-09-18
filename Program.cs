using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace VideoGameShop;

class Program
{
    static void Main(string[] args)
    {
        
        string filePath = "C:\\Users\\19yus\\OneDrive\\Masaüstü\\C# Basics\\ASSIGNMENT2 FOR CSHARP - 2ND SEMESTER\\ASSIGNMENT2 FOR CSHARP - 2ND SEMESTER\\VideoGames.txt";
        bool menu = true;
        bool playAgain = true;
        
        while(menu)
        {
            string answer;
            
            while (playAgain)
                    {
                        Console.WriteLine("1 - Add new Video Game");
                        Console.WriteLine("2 - List current games");
                        Console.WriteLine("3 - Exit");
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
                                Console.WriteLine("Games: ");
                                foreach (var game in allGames)
                                {
                                    Console.WriteLine(game);
                                }
                            }
                        }else if (input == "3")
                        {
                            Console.WriteLine("Would you like to go back to menu? (Yes/No) ");
                            answer = Console.ReadLine();
                            answer = answer.ToUpper();
                        
                            if(answer == "YES")
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
                        break;
                    }        
        }
        Console.ReadLine();
        
    }
    

    
    
}