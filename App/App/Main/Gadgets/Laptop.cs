namespace App.Main.Gadgets;

public class Laptop(int id, string model, int ramInGb, bool isSsd)
    : Gadgets(id, model)
{
    public int RamInGb { get; set; } = ramInGb;
    public bool IsSsd { get; set; } = isSsd;
}