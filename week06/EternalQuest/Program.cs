// EXCEEDING REQUIREMENTS:
// - Added bonus points for checklist completion
// - Used polymorphism with virtual/override methods
// - File save/load using a simple text format

using System;

using System.Collections.Generic;
using System.IO;


class Program
{
    static void Main()
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}

abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetails();
    public abstract string GetStringRepresentation();
}
