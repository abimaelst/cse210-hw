public class User
{
    private int _points;

    public int Points { get => _points; }
    public int Level => _points / 1000;

    public void AddPoints(int points)
    {
        _points += points;
    }

    public string DisplayStatus()
    {
        return $"Level: {Level}, Points: {_points}";
    }
}
