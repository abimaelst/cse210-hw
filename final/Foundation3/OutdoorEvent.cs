public class OutdoorEvent : Event
{
    public string Weather { get; set; }

    public OutdoorEvent(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        Weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{base.GetStandardDetails()}\nWeather forecast: {Weather}";
    }
}
