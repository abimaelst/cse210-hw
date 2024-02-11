public class SimpleGoal : Goal
{
    public SimpleGoal(string title, int pointsValue) : base(title, pointsValue) { }

    public override void CompleteGoal()
    {
        IsComplete = true;
    }

    public override string DisplayGoal()
    {
        return $"[Simple] {Title} - {PointsValue} Points";
    }
}
