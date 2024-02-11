public class ChecklistGoal : Goal
{
    private int _targetCompletions;
    private int _currentCompletions;

    public ChecklistGoal(string title, int pointsValue, int targetCompletions) : base(title, pointsValue)
    {
        _targetCompletions = targetCompletions;
        _currentCompletions = 0;
    }

    public override void CompleteGoal()
    {
        _currentCompletions++;
        if (_currentCompletions >= _targetCompletions) {
            IsComplete = true;
        }
    }

    public override string DisplayGoal()
    {
        return $"[Checklist] {Title} - {PointsValue} Points, Completed {_currentCompletions}/{_targetCompletions}";
    }
}
