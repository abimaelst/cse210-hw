using System;

public class Event
{
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Date { get; set; }
    public string Time { get; set; }
    public Address Address { get; set; }

    public Event(string title, string description, DateTime date, string time, Address address)
    {
        Title = title;
        Description = description;
        Date = date;
        Time = time;
        Address = address;
    }

    public virtual string GetStandardDetails()
    {
        return $"{Title}\n{Description}\nDate: {Date.ToShortDateString()} Time: {Time}\nLocation: {Address.GetFullAddress()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public virtual string GetShortDescription()
    {
        return $"Event: {Title} on {Date.ToShortDateString()}";
    }
}
