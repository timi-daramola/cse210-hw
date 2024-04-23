using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";
        string grade_symbol = "";
        string grade_sign = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (percent % 10 >=7)
        {
            grade_sign  = letter;
        }
        else if (percent % 10 >=3 && percent % 10 <=6)
        {
            grade_sign  = letter;
        }
        else 
        {
            grade_symbol = "-";
            grade_sign  = letter + grade_symbol;
        }

        Console.WriteLine($"Your grade is: {grade_sign}");
        
        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}