using App.Main;

namespace App.Container;

public class RentContainer
{
    private static readonly List<Rents> Rents = [];

    public static void Add(Rents gadget) => Rents.Add(gadget);

    public static Rents GetSingle(int id) => Rents.First(g => g.Id == id);

    public static IEnumerable<Rents> GetAll() => Rents;
}