public class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string title, int pointsValue) : base(title, pointsValue)
    {
        _timesCompleted = 0;
    }

    public override void CompleteGoal()
    {
        _timesCompleted++;
        Console.WriteLine($"{Title} completed {_timesCompleted} times.");
    }

    public override string DisplayGoal()
    {
        return $"[Eternal] {Title} - {PointsValue} Points, Times Completed: {_timesCompleted}";
    }
}
