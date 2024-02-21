using System;

class Program
{
    static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(DateTime.Now, 30, 3.0), // Example with Running, assuming 3 miles in 30 minutes
            // Add instances of Cycling and Swimming here following the similar pattern
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}