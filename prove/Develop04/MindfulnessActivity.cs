using System;
using System.Threading;

class MindfulnessActivity
{
    protected string activityName;
    protected string activityDescription;
    protected int duration;

    public MindfulnessActivity(string name, string description)
    {
        activityName = name;
        activityDescription = description;
        duration = 0;
    }

    public virtual void StartActivity()
    {
        Console.WriteLine($"Starting {activityName} activity...");
        Console.WriteLine(activityDescription);

        SetDuration();
        PrepareForActivity();

        PerformActivity();

        FinishActivity();
    }

    protected virtual void SetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    protected void PrepareForActivity()
    {
        Console.WriteLine("Get ready to begin...");
        Thread.Sleep(2000);
    }

    protected virtual void PerformActivity()
    {
        Console.WriteLine($"Performing {activityName} activity for {duration} seconds...");
        Thread.Sleep(duration * 1000);
    }

    protected void FinishActivity()
    {
        Console.WriteLine("Great job! Activity completed.");
        Console.WriteLine($"You have completed {activityName} for {duration} seconds.");
        Thread.Sleep(2000);
    }
}