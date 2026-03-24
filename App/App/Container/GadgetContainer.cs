using App.Main.Gadgets;

namespace App.Container;

public class GadgetContainer
{
    private static readonly List<Gadgets> Gadgets = [];

    public static void Add(Gadgets gadget) => Gadgets.Add(gadget);

    public static Gadgets GetSingle(int id) => Gadgets.First(g => g.Id == id);

    public static IEnumerable<Gadgets> GetAll() => Gadgets;
}