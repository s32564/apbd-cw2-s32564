namespace App.Main.Users;

public class Student(int id, string name, string surname) : Users(id, name, surname)
{
    public override int MaxRents => 2;
}