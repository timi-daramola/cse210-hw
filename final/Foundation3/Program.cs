using System;

class Program
{
    static void Main(string[] args)
    {
        Address concertAddress = new Address("Pro-dome event center", "Northriding", "Gauteng", "South Africa");
        Address conferenceAddress = new Address("78 Terrace road, Bezuidenhout Valley", "Johannesburg", "Gauteng", "South Africa");
        Address webinarAddress = new Address("55 President Street", "Johannesburg", "Gauteng", "South Africa");

        Event concert = new Concert("Worship Night", DateTime.Parse("2024-06-15"), concertAddress, "Soweto Choir");
        Event conference = new Conference("Night of Entertainment", DateTime.Parse("2024-07-20"), conferenceAddress, "The Talented");
        Event webinar = new Webinar("Comedy Night", DateTime.Parse("2024-08-10"), webinarAddress, "Trevor Noah");

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
    private string Province { get; }
    private string Country { get; }

    public Address(string street, string city, string province, string country)
    {
        Street = street;
        City = city;
        Province = province;
        Country = country;
    }

    public string GetFullAddress()
    {
        return $"{Street}, {City}, {Province}, {Country}";
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
        return $"Attend our entertainment show by {Topic} and have a memorable experience!";
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
        return $"Join our comedy show featuring {Speaker} and enjoy endless laughter!";
    }
}