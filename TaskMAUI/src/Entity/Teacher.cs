namespace TaskMAUI.Entity;

public class Teacher : User
{
    
    public void SendNotification(Student student, String notification)
    {
        Console.WriteLine($"Send notification {notification} to {student}");
    }

    public void ViewMissedPrayers(Student student)
    {
        Console.WriteLine($"View missed student {student}");
        student.ShowPrayerStatus();
    }
}