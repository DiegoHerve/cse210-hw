class ChecklistGoal : Goal
{
    private int _target;
    private int _bonus;
    private int _completed;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int completed = 0)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _completed = completed;
    }

    public int GetBonus() { return _bonus; }

    public override void RecordEvent()
    {
        if (_completed < _target)
            _completed++;
    }

    public override bool IsComplete() { return _completed >= _target; }
    public override string GetTypeName() { return "Checklist"; }

    public override string GetDetails()
    {
        return base.GetDetails() + " — Completed " + _completed + "/" + _target + " times";
    }

    public override string SaveString()
    {
        return base.SaveString() + "|" + _target + "|" + _bonus + "|" + _completed;
    }
}
