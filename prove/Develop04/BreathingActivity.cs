using System;
using System.Threading;

class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    protected override void PerformActivity()
    {
        Console.WriteLine("Breathe in...");
        Thread.Sleep(_duration * 500); // Pause for half of the specified duration
        Console.WriteLine("Breathe out...");
        Thread.Sleep(_duration * 500); // Pause for half of the specified duration

        base.PerformActivity();
    }
}