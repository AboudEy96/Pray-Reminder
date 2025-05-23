namespace TaskMAUI.Pray;

public class MissedPrayerStrategy : IPrayerStatusStrategy
{
    public string GetPrayerStatus() => "this Prayer was missed";

}