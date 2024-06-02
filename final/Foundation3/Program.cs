using System;

class Program
{
    static void Main(string[] args)
    {
        Address concertAddress = new Address("123 Main St", "Anytown", "CA", "USA");
        Address conferenceAddress = new Address("456 Elm St", "Othertown", "NY", "USA");
        Address webinarAddress = new Address("789 Oak St", "Anothertown", "TX", "USA");

        Event concert = new Concert("Rock Night", DateTime.Parse("2024-06-15"), concertAddress, "The Rock Band");
        Event conference = new Conference("Tech Summit", DateTime.Parse("2024-07-20"), conferenceAddress, "Emerging Technologies");
        Event webinar = new Webinar("Introduction to AI", DateTime.Parse("2024-08-10"), webinarAddress, "Dr. AI Expert");

        Console.WriteLine("Concert Marketing Message:");
        Console.WriteLine(concert.GenerateMarketingMessage());
        Console.WriteLine(concert.GetEventDetails());
        Console.WriteLine();

        Console.WriteLine("Conference Marketing Message:");
        Console.WriteLine(conference.GenerateMarketingMessage());
        Console.WriteLine(conference.GetEventDetails());
        Console.WriteLine();

        Console.WriteLine("Webinar Marketing Message:");
        Console.WriteLine(webinar.GenerateMarketingMessage());
        Console.WriteLine(webinar.GetEventDetails());
        Console.WriteLine();
    }
}


class Address
{
    private string Street { get; }
    private string City { get; }
    private string StateProvince { get; }
    private string Country { get; }

    public Address(string street, string city, string stateProvince, string country)
    {
        Street = street;
        City = city;
        StateProvince = stateProvince;
        Country = country;
    }

    public string GetFullAddress()
    {
        return $"{Street}, {City}, {StateProvince}, {Country}";
    }
}

class Event
{
    private string Name { get; }
    private DateTime Date { get; }
    private Address Location { get; }

    public Event(string name, DateTime date, Address location)
    {
        Name = name;
        Date = date;
        Location = location;
    }

    public string GetEventDetails()
    {
        return $"Event Name: {Name}\nDate: {Date}\nLocation: {Location.GetFullAddress()}";
    }

    public virtual string GenerateMarketingMessage()
    {
        return "Join us for an exciting event!";
    }
}

class Concert : Event
{
    private string BandName { get; }

    public Concert(string name, DateTime date, Address location, string bandName) : base(name, date, location)
    {
        BandName = bandName;
    }

    public override string GenerateMarketingMessage()
    {
        return $"Come see {BandName} live in concert!";
    }
}

class Conference : Event
{
    private string Topic { get; }

    public Conference(string name, DateTime date, Address location, string topic) : base(name, date, location)
    {
        Topic = topic;
    }

    public override string GenerateMarketingMessage()
    {
        return $"Attend our conference on {Topic} and gain valuable insights!";
    }
}

class Webinar : Event
{
    private string Speaker { get; }

    public Webinar(string name, DateTime date, Address location, string speaker) : base(name, date, location)
    {
        Speaker = speaker;
    }

    public override string GenerateMarketingMessage()
    {
        return $"Join our webinar featuring {Speaker} and learn from the expert!";
    }
}