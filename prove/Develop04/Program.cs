//Creativity | I generated the questions randomly. This is one of the most challenging projects for me this semester but I thank God I managed to solve it and I have a lot from it. Thank you for the knowledge.

using System;

class Program
{
    static Random random = new Random();

    static void Main(string[] args)
    {
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");
        string choice = Console.ReadLine();

        if(choice == "1"){
            breathingActivity();
        }else if(choice == "2"){
            reflectingActivity();
        }else if(choice == "3"){
            listingActivity();
        }else if(choice != "1" || choice != "2" || choice != "3"){
            Console.WriteLine("Goodbye. You may restart to try again.");
        }
    }

    static void breathingActivity(){
        Console.WriteLine("Welcome to the Breathing Activity.");
            Console.WriteLine("\nThis activity wll help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.Write("\nHow long, in seconds, would you like for your session? ");
            int duration = int.Parse(Console.ReadLine());
            clearConsole();

            Console.WriteLine("Get ready...");
            Animation.animationStrings();
            Console.WriteLine("\n");

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(duration);

            while(DateTime.Now < endTime)
            {            
                Console.Write("Breathe in...");
                for(int s=5; s>0; s--){
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
                }
                Console.Write("\nNow breathe out...");
                for(int s=5; s>0; s--){
                    Console.Write(s);
                    Thread.Sleep(1000);
                    Console.Write("\b \b");
                }
                Console.WriteLine("\n");
                
                int durationCount = duration + 1000;
                Thread.Sleep(durationCount);
            }
            Console.WriteLine("Well done!!");
            Animation.animationStrings();
            Console.WriteLine($"\nYou have completed another {duration} seconds of the Breathing Activity.");
            Animation.animationStrings();
    }

    static void reflectingActivity(){

        Console.WriteLine("Welcome to the Reflecting Activity.");
        Console.WriteLine("\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        clearConsole();

        Console.WriteLine("Get ready...");
        Animation.animationStrings();
        Console.WriteLine("\n");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("--- Think of a time when you did something really difficult. ---");

        Console.Write("When you have something in mind, press enter to continue.\n");
        string blankChoice = Console.ReadLine();

        Console.Write("Now ponder on each of the following questions as they related to this experience. You may begin in: ");
        for(int s=5; s>0; s--){
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        }
        clearConsole();

        reflectingQuestionGenerator();
        Animation.animationStrings();

        reflectingQuestionGenerator();
        Animation.animationStrings();

        Console.WriteLine("\nWell done!!");
        Animation.animationStrings();

        Console.WriteLine($"\nYou have completed another {duration} seconds of the Reflecting Activity.");
        Animation.animationStrings();
    }

    static void clearConsole()
    {
        Console.Clear();
    }


    static void listingActivity(){

        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine("\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        clearConsole();

        Console.WriteLine("Get ready...");
        Animation.animationStrings();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        Console.WriteLine("List as many responses you can to the following prompt: ");
        listingQuestionGenerator();
        Console.Write("You may begin in: ");
        for(int s=5; s>0; s--){
        Console.Write(s);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        }
        
        Console.WriteLine("\n");
        int count = 0;
        while(DateTime.Now < endTime)
        {            
            Console.Write("> ");
            string firstResponse = Console.ReadLine();
            count++;
            
            int durationCount = duration + 1000;
            Thread.Sleep(durationCount);
        }
        
        Console.WriteLine($"You listed {count} items!");
        Animation.animationStrings();

        Console.WriteLine("\nWell done!!");
        Animation.animationStrings();

        Console.WriteLine($"\nYou have completed another {duration} seconds of the Listing Activity.");
        Animation.animationStrings();
    }




    static void reflectingQuestionGenerator(){
        var rand = new Random();

        var questions = new List<string>{
            "> How did you feel when it was complete?", "> What is your favorite thing about this experience?", "> Why was this experience meaningful to you?", "> Have you ever done anything like this before?", "> How did you get started?", "> How did you feel when it was complete?"
        };

        int nextQuestion = questions.Count;
        int questionIndex = rand.Next(nextQuestion);
        Console.WriteLine(questions[questionIndex]);
    }

    static void listingQuestionGenerator(){
        var rand = new Random();

        var questions = new List<string>{
            "--- When have you felt the holy Ghost this month? ---", "--- What are your testimonies for this month? ---", "--- How much do you experience holy Ghost this month? ---", "--- What made this time different than other times when you were not as successful? ---",
            "--- What is your favorite thing about this experience? ---", 
            "--- What could you learn from this experience that applies to other situations? ---", "--- What did you learn about yourself through this experience? ---", "--- How can you keep this experience in mind in the future? ---"
        };

        int nextQuestion = questions.Count;
        int questionIndex = rand.Next(nextQuestion);
        Console.WriteLine(questions[questionIndex]);
    }
}

static class Animation {
        public static void animationStrings(){

        List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");

        foreach (string item in animationStrings)
        {
            Console.Write(item);
            Thread.Sleep(800);
            Console.Write("\b \b");
        }
    }
}
