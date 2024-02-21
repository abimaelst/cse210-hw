using System;

public abstract class Activity
{
    public DateTime Date { get; set; }
    public int LengthInMinutes { get; set; }

    protected Activity(DateTime date, int lengthInMinutes)
    {
        Date = date;
        LengthInMinutes = lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();
    
    public virtual string GetSummary()
    {
        return $"{Date.ToString("dd MMM yyyy")}: {this.GetType().Name} ({LengthInMinutes} min) - Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
