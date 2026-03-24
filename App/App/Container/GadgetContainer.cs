using App.Main.Gadgets;

namespace App.Container;

public class GadgetContainer : IGadgetContainer
{
    private readonly List<Gadgets> _gadgets = [];

    public void Add(Gadgets gadget) => _gadgets.Add(gadget);

    public Gadgets GetSingle(int id) => _gadgets.First(g => g.Id == id);

    public IEnumerable<Gadgets> GetAll() => _gadgets;
}