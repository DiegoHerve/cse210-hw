class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public string GetName() { return _name; }
    public int GetPoints() { return _points; }

    public virtual void RecordEvent() { }
    public virtual bool IsComplete() { return false; }
    public virtual string GetDetails() { return _name + " (" + _description + ")"; }
    public virtual string GetTypeName() { return "Goal"; }

    public virtual string SaveString()
    {
        return GetTypeName() + "|" + _name + "|" + _description + "|" + _points;
    }
}
