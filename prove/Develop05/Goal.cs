public abstract class Goal
{
    private string _title;
    private int _pointsValue;
    private bool _isComplete;

    public string Title { get => _title; set => _title = value; }
    public int PointsValue { get => _pointsValue; set => _pointsValue = value; }
    public bool IsComplete { get => _isComplete; set => _isComplete = value; }

    protected Goal(string title, int pointsValue)
    {
        _title = title;
        _pointsValue = pointsValue;
        _isComplete = false;
    }

    public abstract void CompleteGoal();
    public abstract string DisplayGoal();
}
