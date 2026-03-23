namespace App.Main.Gadgets;

public class Camera : Gadgets
{
    public int QualityMp { get; set; }
    public bool WithNightMode { get; set; }

    public Camera(int id, string model, int qualityMp, bool withNightMode) : base(id, model)
    {
        QualityMp = qualityMp;
        WithNightMode = withNightMode;
    }
}