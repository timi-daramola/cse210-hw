//Student: Timilehin Daramola | Creativity: I added an extra feature to make the program continuously prompt the users for more tries without breaking out of the code until 'quit' is entered.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static Random random = new Random();
    
    static void Main(string[] args)
    {
        string userInput = "";
        List<string> scriptures = new List<string> {"Proverbs 3:5-6", "Trust", "in the", "LORD with", "all your", "heart and lean", "not on", "your own", "understanding;", "in all your", "ways submit", "to him,", "and he will", "make your", "paths", "straight."};

        foreach(string scripture in scriptures)
        {
            Console.Write(scripture + " ");          
        }
        
        userPrompt();

        while (userInput.ToLower() != "quit")
        {
            if(userInput == "")
            {
                List<string> newWord = new List<string>();
                foreach(string scripture in scriptures)
                {
                    if (random.Next(5) == 0)
                        newWord.Add(new string('_', scripture.Length));
                    else
                        newWord.Add(scripture);
                }
                Console.WriteLine(string.Join(" ", newWord));
                userPrompt();
            }
            else
            {
                clearConsole();
            }
        }
        
    }

    static void clearConsole()
    {
        Console.Clear();
    }

    static void userPrompt()
    {
        string userInput = "";
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
        userInput = Console.ReadLine();
    }
}