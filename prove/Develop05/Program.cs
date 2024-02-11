using System;

class Program
{

    static GoalManager goalManager = new GoalManager();

    static void Main(string[] args)
    {

        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Eternal Quest Program");
            Console.WriteLine("1. Add Goal");
            Console.WriteLine("2. Complete Goal");
            Console.WriteLine("3. Display Goals");
            Console.WriteLine("4. Display User Status");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddGoal();
                    break;
                case 2:
                    CompleteGoal();
                    break;
                case 3:
                    goalManager.DisplayGoals();
                    break;
                case 4:
                    Console.WriteLine(goalManager.User.DisplayStatus());
                    break;
                case 5:
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void AddGoal()
        {
            Console.Write("Enter goal title: ");
            string title = Console.ReadLine();
            Console.Write("Enter points value: ");
            int pointsValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Select goal type: 1. Simple 2. Eternal 3. Checklist");
            int type = Convert.ToInt32(Console.ReadLine());

            Goal goal;
            switch (type)
            {
                case 1:
                    goal = new SimpleGoal(title, pointsValue);
                    break;
                case 2:
                    goal = new EternalGoal(title, pointsValue);
                    break;
                case 3:
                    Console.Write("Enter target completions: ");
                    int targetCompletions = Convert.ToInt32(Console.ReadLine());
                    goal = new ChecklistGoal(title, pointsValue, targetCompletions);
                    break;
                default:
                    Console.WriteLine("Invalid type, defaulting to Simple.");
                    goal = new SimpleGoal(title, pointsValue);
                    break;
            }

            goalManager.AddGoal(goal);
            Console.WriteLine("Goal added successfully.");
        }

        static void CompleteGoal()
        {
            goalManager.DisplayGoals();
            Console.Write("Enter the index of the goal to complete: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;
            goalManager.CompleteGoal(index);
        }

    }
}