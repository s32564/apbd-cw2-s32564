namespace App.Main.Gadgets;

public class Gadgets
{
    public int Id { get; }
    public string Model { set; get; }
    public bool IsAvailable { set; get; }

    protected Gadgets(int id, string model)
    {
        Id = id;
        Model = model;
    }

    public void SetAvailable(bool isAvailable)
    {
        IsAvailable = true;
    }

    public void SetUnavailable()
    {
        IsAvailable = false;
    }
}