public class Running : Activity
{
    public double Distance { get; set; } // in miles for simplicity

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
        // Speed in miles per hour
        return (Distance / LengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        // Pace in minutes per mile
        return LengthInMinutes / Distance;
    }
}
