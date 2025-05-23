namespace TaskMAUI.Entity;

public class User
{
    public int ID { get; set; }
    public string Name {get; set;}
    public string Password {get; set;}

    public virtual void Login()
    {
        Console.WriteLine($"Login {Name}");
    }

    public virtual void Register()
    {
        Console.WriteLine($"Register {Name}");
    }

    public virtual void ShowInfo()
    {
        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");
        Console.WriteLine($"User: - {Name} - ID: {ID} \nPassword: {Password}");
        Console.WriteLine("+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-");


        
    }
}