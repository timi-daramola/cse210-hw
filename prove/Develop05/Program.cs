using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<string> _goals1 = new List<string>();
        List<string> _goals2 = new List<string>();
        int points = 0;
        int count = 0;
        string choice = "";
        string secondChoice = "";
        string typeChoice = "";
        string _shortName = "";
        string _description = "";
        string _points = "";

        choice = GoalManager.Start(choice);
            if(choice == "1"){
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                typeChoice = Console.ReadLine();

                if(typeChoice == "1"){
                    secondChoice = "Simple Goal";
                    count++;
                    Console.Write("What is the name of your goal? ");
                    _shortName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    _description = Console.ReadLine();
                    _goals1.Add($"{count}. [] {_shortName} ({_description})");
                    Console.Write("What is the amount of points associated with this goal? ");
                    _points = Console.ReadLine();
                    _goals2.Add($"{secondChoice}: {_shortName}, {_description}, {points}");
                    Console.WriteLine($"\nYou have {points} points.\n");
                }else if(typeChoice == "2"){
                    secondChoice = "Eternal Goal";
                    count++;
                    Console.Write("What is the name of your goal? ");
                    _shortName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    _description = Console.ReadLine();
                    _goals1.Add($"{count}. [] {_shortName} ({_description})");
                    Console.Write("What is the amount of points associated with this goal? ");
                    _points = Console.ReadLine();
                    _goals2.Add($"{secondChoice}: {_shortName}, {_description}, {points}");
                    Console.WriteLine($"\nYou have {points} points.\n");
                }else if(typeChoice == "3"){
                    secondChoice = "Checklist Goal";
                    count++;
                    Console.Write("What is the name of your goal? ");
                    _shortName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    _description = Console.ReadLine();
                    _goals1.Add($"{count}. [] {_shortName} ({_description})");
                    Console.Write("What is the amount of points associated with this goal? ");
                    _points = Console.ReadLine();
                    _goals2.Add($"{secondChoice}: {_shortName}, {_description}, {points}");
                    Console.WriteLine($"\nYou have {points} points.\n");
                }
            }else if(choice == "2"){
                foreach(string goal in _goals1){
                    Console.WriteLine(goal);
                }
                choice = GoalManager.Start(choice);
            }else if(choice == "4" && choice == "2"){
                foreach(string goal in _goals2){
                    Console.WriteLine(goal);
                }
            }else if(choice == "3"){
                string fileName = "";
                
                Console.Write("What is the filename for the goal file? ");
                fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    // You can add text to the file with the WriteLine method
                    foreach(string goal in _goals2){
                        outputFile.WriteLine($"{goal}");
                    }
                }
            }else if(choice == "4"){
                string fileName = "";

                Console.Write("What is the filename for the goal file? ");
                fileName = Console.ReadLine();
                string[] openedFile = System.IO.File.ReadAllLines(fileName);

                
                foreach (string line in openedFile)
                {
                    _goals2.Add($"{line}");
                }
            }else if(choice == "5"){
                // pass;
            }else if(choice != "1" || choice != "2" || choice != "3" || choice != "4" || choice != "5"){
                Console.WriteLine("Goodbye. You may restart the application to retry.");
            }
            

        while(choice != ""){
            choice = GoalManager.Start(choice);
            if(choice == "1"){
                Console.WriteLine("The types of Goals are: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                typeChoice = Console.ReadLine();

                if(typeChoice == "1"){
                    secondChoice = "Simple Goal";
                    count++;
                    Console.Write("What is the name of your goal? ");
                    _shortName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    _description = Console.ReadLine();
                    _goals1.Add($"{count}. [] {_shortName} ({_description})");
                    Console.Write("What is the amount of points associated with this goal? ");
                    _points = Console.ReadLine();
                    _goals2.Add($"{secondChoice}: {_shortName}, {_description}, {points}");
                    Console.WriteLine($"\nYou have {points} points.\n");
                }else if(typeChoice == "2"){
                    secondChoice = "Eternal Goal";
                    count++;
                    Console.Write("What is the name of your goal? ");
                    _shortName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    _description = Console.ReadLine();
                    _goals1.Add($"{count}. [] {_shortName} ({_description})");
                    Console.Write("What is the amount of points associated with this goal? ");
                    _points = Console.ReadLine();
                    _goals2.Add($"{secondChoice}: {_shortName}, {_description}, {points}");
                    Console.WriteLine($"\nYou have {points} points.\n");
                }else if(typeChoice == "3"){
                    secondChoice = "Checklist Goal";
                    count++;
                    Console.Write("What is the name of your goal? ");
                    _shortName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    _description = Console.ReadLine();
                    _goals1.Add($"{count}. [] {_shortName} ({_description})");
                    Console.Write("What is the amount of points associated with this goal? ");
                    _points = Console.ReadLine();
                    _goals2.Add($"{secondChoice}: {_shortName}, {_description}, {points}");
                    Console.WriteLine($"\nYou have {points} points.\n");
                }
            }else if(choice == "2"){
                foreach(string goal in _goals1){
                    Console.WriteLine(goal);
                }
                choice = GoalManager.Start(choice);
            }else if(choice == "4" && choice == "2"){
                foreach(string goal in _goals2){
                    Console.WriteLine(goal);
                }
            }else if(choice == "3"){
                string fileName = "";
                
                Console.Write("What is the filename for the goal file? ");
                fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    // You can add text to the file with the WriteLine method
                    foreach(string goal in _goals2){
                        outputFile.WriteLine($"{goal}");
                    }
                }
            }else if(choice == "4"){
                string fileName = "";

                Console.Write("What is the filename for the goal file? ");
                fileName = Console.ReadLine();
                string[] openedFile = System.IO.File.ReadAllLines(fileName);

                
                foreach (string line in openedFile)
                {
                    _goals2.Add($"{line}");
                }
            }else if(choice == "5"){
                // pass;
            }else if(choice != "1" || choice != "2" || choice != "3" || choice != "4" || choice != "5"){
                Console.WriteLine("Goodbye. You may restart the application to retry.");
            }
        }
    }

}

class GoalManager
{
    public static string Start(string choice){
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");
        choice = Console.ReadLine();
        
        return choice;
    }
}

