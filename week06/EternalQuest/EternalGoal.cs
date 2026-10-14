class EternalGoal : Goal
{
    private int _timesCompleted;

    public EternalGoal(string name, string description, int points, int timesCompleted = 0)
        : base(name, description, points)
    {
        _timesCompleted = timesCompleted;
    }

    public override void RecordEvent() { _timesCompleted++; }
    public override bool IsComplete() { return false; }
    public override string GetTypeName() { return "Eternal"; }

    public override string GetDetails()
    {
        return base.GetDetails() + " — recorded " + _timesCompleted + " time(s)";
    }

    public override string SaveString()
    {
        return base.SaveString() + "|" + _timesCompleted;
    }
}
