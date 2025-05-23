namespace TaskMAUI.Pray;

public class Prayer
{
    private IPrayerStatusStrategy _startegy;

    public Prayer(IPrayerStatusStrategy strategy)
    {
        this._startegy = strategy;
    }

    public void SetStrategy(IPrayerStatusStrategy strategy)
    {
        _startegy = strategy;
    }

    public string CheckPrayerStatus()
    {
        return _startegy.GetPrayerStatus();
    }
    
}