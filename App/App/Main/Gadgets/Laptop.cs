namespace App.Main.Gadgets;

public class Laptop : Gadgets
{
    public int RamInGb { get; set; }
    public bool IsSsd { get; set; }

    public Laptop(int id, string model, int ramInGb, bool isSsd) : base(id, model)
    {
        RamInGb = ramInGb;
        IsSsd = isSsd;
    }
}