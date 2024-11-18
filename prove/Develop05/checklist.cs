public class Checklist : Goal
{
    private int _bonusPoints;
    private int _timesCompleted;
    private int _timesForBonus;
    public override string CompressInfo()
    {
        return $"Checklist Goal:{_name}%,{_description}%,{_points}%,{_bonusPoints}%,{_timesForBonus}%,{_timesCompleted}";
    }

    public override string DisplayInfo()
    {
        if (_timesCompleted >= _timesForBonus)
        {
            return $"[X] {_name} ({_description}) -- Completed {_timesCompleted}/{_timesForBonus}";
        }
        else
        {
            return $"[ ] {_name} ({_description}) -- Completed {_timesCompleted}/{_timesForBonus}";
        }
    }

    public override int ProgressEvent()
    {
        int pointsAwarded = _points;
        _timesCompleted += 1;
        if (_timesCompleted == _timesForBonus)
        {
            pointsAwarded += _bonusPoints;
        }
        return pointsAwarded;
    }

    public override void SetInfo()
    {
        throw new NotImplementedException();
    }
    public Checklist(string name, string description, int points, int bonusPoints, int timesForBonus) : base(name, description, points)
    {
        _bonusPoints = bonusPoints;
        _timesCompleted = 0;
        _timesForBonus = timesForBonus;
    }

}