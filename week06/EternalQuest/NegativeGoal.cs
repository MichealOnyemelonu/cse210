class NegativeGoal : Goal
{
    public NegativeGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        
        return -_points;
    }

    public override bool IsComplete() => false;

    public override string GetDetails()
    {
        return $"[!] {_name} ({_description}) -- Penalty: -{_points} pts";
    }

    public override string GetStringRepresentation()
    {
        return $"Negative|{_name}|{_description}|{_points}";
    }
}