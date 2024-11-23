public class Simple : Goal
{
    private bool _completed;
    public override string CompressInfo()
    {
        return $"Simple Goal:{_name}%,{_description}%,{_points}%,{_completed}";
    }

    public override string DisplayInfo()
    {
        if (_completed)
        {
            return $"[X] {_name} ({_description})";
        }
        else
        {
            return $"[ ] {_name} ({_description})";
        }
    }

    public override int ProgressEvent()
    {
        _completed = true;
        return _points;
    }

    public override void SetInfo()
    {
        throw new NotImplementedException();
    }
    public Simple(string name, string description, int points) : base(name, description, points)
    {
        _completed = false;
    }
    public Simple(string name, string description, int points, bool completed) : base(name, description, points)
    {
        _completed = completed;
    }

}