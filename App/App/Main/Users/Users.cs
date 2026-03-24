namespace App.Main.Users;

public abstract class Users(int id, string name, string surname)
{
    public int Id { get; } = id;
    public string Name { get; set;  } = name;
    public string Surname { get; set; } = surname;
    public abstract int MaxTimes { get; }
}