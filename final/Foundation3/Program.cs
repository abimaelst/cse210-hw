using System;

class Program
{
    static void Main(string[] args)
    {
        var events = new Event[]
        {
            new LectureEvent("Tech Innovations", "Exploring Future Tech", DateTime.Now.AddDays(30), "2:00 PM", new Address("123 Tech Lane", "Techville", "Tech State", "USA"), "Dr. Tech Savvy", 100),
            new ReceptionEvent("Wedding Reception", "Celebrating Love", DateTime.Now.AddDays(60), "5:00 PM", new Address("456 Love St", "Lovetown", "Love State", "USA"), "rsvp@love.com"),
            new OutdoorEvent("Community Picnic", "A day of fun and games", DateTime.Now.AddDays(90), "11:00 AM", new Address("789 Park Ave", "Funville", "Fun State", "USA"), "Sunny with a chance of happiness")
        };

        foreach (var eventItem in events)
        {
            Console.WriteLine(eventItem.GetFullDetails());
            Console.WriteLine("------------------------------");
        }
    }
}