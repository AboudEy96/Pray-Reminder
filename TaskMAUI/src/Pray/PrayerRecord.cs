namespace TaskMAUI.Pray;

public class PrayerRecord
{
    public string PrayerName { get; set; }
    public IPrayerStatusStrategy PrayerStartegy { get; set; }
    // show status of selected prayer
    public string GetStatus() => PrayerStartegy.GetPrayerStatus();
}