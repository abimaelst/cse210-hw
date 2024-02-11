using System;
using System.Collections.Generic;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private User _user = new User();

    public User User { get => _user; }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void CompleteGoal(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            _goals[index].CompleteGoal();
            _user.AddPoints(_goals[index].PointsValue);
            Console.WriteLine("Goal completed!");
            Console.WriteLine(_user.DisplayStatus());
        }
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].DisplayGoal()}");
        }
    }
}
