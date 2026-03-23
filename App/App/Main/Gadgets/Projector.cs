namespace App.Main.Gadgets;

public class Projector : Gadgets
{
    public int Resolution { get; set; }
    public int Lumens { get; set; }

    public Projector(int id, string model, int resolution, int lumens) : base(id, model)
    {
        Resolution = resolution;
        Lumens = lumens;
    }
}