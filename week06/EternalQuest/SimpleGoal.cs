using System;

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) 
        : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"[{(IsComplete() ? "X" : " ")}] {_name} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_isComplete}";
    }

    public static SimpleGoal CreateFromString(string data)
    {
        string[] parts = data.Split(',');
        SimpleGoal goal = new SimpleGoal(parts[0], parts[1], int.Parse(parts[2]));
        goal._isComplete = bool.Parse(parts[3]);
        return goal;
    }
}