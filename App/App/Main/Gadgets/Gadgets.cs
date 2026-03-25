namespace App.Main.Gadgets;

public class Gadgets(int id, string model)
{
    public int Id { get; } = id;
    public string Model { set; get; } = model;
    public bool IsAvailable { private set; get; } = true;

    public void SetAvailable()
    {
        IsAvailable = true;
    }

    public void SetUnavailable()
    {
        IsAvailable = false;
    }
}