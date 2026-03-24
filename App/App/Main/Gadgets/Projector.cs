namespace App.Main.Gadgets;

public class Projector(int id, string model, int resolution, int lumens)
    : Gadgets(id, model)
{
    public int Resolution { get; set; } = resolution;
    public int Lumens { get; set; } = lumens;
}