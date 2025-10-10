using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) 
        : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_target},{_bonus},{_amountCompleted}";
    }

    public override int GetPoints()
    {
        if (IsComplete() && _amountCompleted == _target)
        {
            // Return regular points plus bonus when completing for the first time
            return _points + _bonus;
        }
        return _points;
    }

    public static ChecklistGoal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        ChecklistGoal goal = new ChecklistGoal(parts[0], parts[1], int.Parse(parts[2]), int.Parse(parts[3]), int.Parse(parts[4]));
        goal._amountCompleted = int.Parse(parts[5]);
        return goal;
    }
}