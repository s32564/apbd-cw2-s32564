namespace App.Main.Users;

public abstract class Users
{
    public int Id { get; }
    public string Name { get; set;  }
    public string Surname { get; set; }
    public abstract int MaxTimes { get; }

    protected Users(int id, string name, string surname)
    {
        Id = id;
        Name = name;
        Surname = surname;
    }
}