namespace App.Main.Gadgets;

public class Camera(int id, string model, int qualityMp, bool withNightMode)
    : Gadgets(id, model)
{
    public int QualityMp { get; set; } = qualityMp;
    public bool WithNightMode { get; set; } = withNightMode;
}