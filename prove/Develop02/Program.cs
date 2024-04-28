//Student: Timilehin Daramola | Creativity. A subscription for reminder was added and properly handled.
using System;
using System.IO;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        List<string> _entries = new List<string>();
        Display();
        int choice = 0;
        string userInput = "";
        string completeEntry = "";
        string generatedPrompt = "";

        while (choice != 5)
        {
            Menu();
            Console.Write("What would you like to do? ");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                generatedPrompt = PrompGenerator();
                userInput = Entry();
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                completeEntry = ($"{dateText} - {generatedPrompt}");
                _entries.Add(completeEntry);
                _entries.Add(userInput);
                _entries.Add($"");

            }
            else if(choice == 2)
            {
                foreach (string makeEntry in _entries)
                {
                    Console.WriteLine($"{makeEntry}");
                }
            }
            else if(choice == 3)
            {
                Console.Write("What is the file name? ");
                string fileName = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    _entries.Add($"{line}");
                }
            }
            else if(choice == 4)
            {
                Journal();
            }
        }
        if(choice == 5)
        {
            Console.Write("You have exited the Journal. Do you want a daily reminder? ");
            string subscribe = Console.ReadLine();
            string subToLower = subscribe.ToLower();
            if(subToLower == "yes")
            {
                Console.WriteLine("Daily reminder has been set. See you again tomorrow.");
            }
            else
            {
                Console.WriteLine("Goodbye.");
            }
        }

        static void Display()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static void Menu()
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Diplay");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
        }

        static string PrompGenerator()
        {
            var random = new Random();
            var list = new List<string>{ 
                "Who was the most interesting person I interacted with today? ",
                "What was the most interesting moment I had today? ",
                "How did I see the hand of the Lord in my life today? ",
                "What new things did I learn today? ",
                "If I had one thing I could do over today, what would it be? "
                };
            int index = random.Next(list.Count);
            string promptIndex = list[index];
            Console.WriteLine(list[index]);
            
            return promptIndex;

        }

        static string Entry()
        {
            Console.Write("> ");
            string userEntry = AddEntry();

            return userEntry;
        }
        
        static string AddEntry()
        {
            string newEntry = Console.ReadLine();

            return newEntry;
        }

        static void Journal()
        {
            List<string> _entries = new List<string>();
            Console.Write("What is the file name? ");
            string fileName = Console.ReadLine();
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (string makeEntry in _entries)
                {
                    Console.WriteLine($"{makeEntry}");
                }
            }
        }
    }
}