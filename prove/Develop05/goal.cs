public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    public abstract string CompressInfo();
    public abstract void SetInfo();
    public abstract string DisplayInfo();
    public abstract int ProgressEvent();

    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }
}