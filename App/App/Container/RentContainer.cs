using App.Main;

namespace App.Container;

public class RentContainer : IRentContainer
{
    private readonly List<Rents> _rents = [];

    public void Add(Rents rent) => _rents.Add(rent);

    public Rents GetSingle(int id) => _rents.First(g => g.Id == id);

    public IEnumerable<Rents> GetAll() => _rents;

    public void Remove(Rents rent) => _rents.Remove(rent);
}