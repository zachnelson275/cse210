public class Eternal : Goal
{
    public override string CompressInfo()
    {
        return $"Eternal Goal:{_name}%,{_description}%,{_points}";
    }
    public override string DisplayInfo()
    {
        return $"[ ] {_name} ({_description})";
    }

    public override int ProgressEvent()
    {
        return _points;
    }

    public Eternal(string name, string description, int points) : base(name, description, points) {}
}