namespace App.Main.Users;

public class Employee(int id, string name, string surname) : Users(id, name, surname)
{
    public override int MaxTimes => 5;
}