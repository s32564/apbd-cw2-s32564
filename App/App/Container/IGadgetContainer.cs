using App.Main.Gadgets;

namespace App.Container;

public interface IGadgetContainer
{
    void Add(Gadgets gadget);
    Gadgets GetSingle(int id);
    IEnumerable<Gadgets> GetAll();
}