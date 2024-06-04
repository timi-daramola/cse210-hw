using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running runningActivity = new Running(DateTime.Parse("2022-11-03"), 30, 3.0);
        Cycling cyclingActivity = new Cycling(DateTime.Parse("2022-11-03"), 45, 15.0);
        Swimming swimmingActivity = new Swimming(DateTime.Parse("2022-11-03"), 60, 10);

        activities.Add(runningActivity);
        activities.Add(cyclingActivity);
        activities.Add(swimmingActivity);

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}


class Activity
{
    protected DateTime Date { get; }
    protected int LengthInMinutes { get; }

    public Activity(DateTime date, int lengthInMinutes)
    {
        Date = date;
        LengthInMinutes = lengthInMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0; 
    }

    public virtual double GetPace()
    {
        return 0; 
    }

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} - Unknown Activity ({LengthInMinutes} min)";
    }
}

class Running : Activity
{
    private double Distance { get; }

    public Running(DateTime date, int lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        Distance = distance;
    }

    public override double GetDistance()
    {
        return Distance;
    }

    public override double GetSpeed()
    {
        return Distance / LengthInMinutes * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / Distance;
    }

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Running ({LengthInMinutes} min) - Distance: {Distance:F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}

class Cycling : Activity
{
    private double Speed { get; }

    public Cycling(DateTime date, int lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        Speed = speed;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetDistance()
    {
        return Speed * LengthInMinutes / 60;
    }

    public override double GetPace()
    {
        return 60 / Speed; 
    }

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Cycling ({LengthInMinutes} min) - Distance: {GetDistance():F2} miles, Speed: {Speed:F2} mph, Pace: {GetPace():F2} min per mile";
    }
}

class Swimming : Activity
{
    private int Laps { get; }

    public Swimming(DateTime date, int lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000 * 0.62; 
    }

    public override double GetSpeed()
    {
        return GetDistance() / LengthInMinutes * 60;
    }

    public override double GetPace()
    {
        return LengthInMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{Date:dd MMM yyyy} Swimming ({LengthInMinutes} min) - Distance: {GetDistance():F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}