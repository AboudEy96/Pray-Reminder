using System.Threading.Tasks.Dataflow;
using TaskMAUI.Pray;

namespace TaskMAUI.Entity;

public class Student : User 
{
    public List<PrayerRecord> PrayerRecordList {get; set;}

    public void ShowPrayerStatus()
    {
        Console.WriteLine($"{Name}'s Missed prayers");

        foreach (var prayer in PrayerRecordList)
        {
            Console.WriteLine($"{prayer} missed.");
        }
    }
}