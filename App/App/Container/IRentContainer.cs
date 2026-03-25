using App.Main;

namespace App.Container;

public interface IRentContainer
{
    void Add(Rents rent);
    Rents GetSingle(int id);
    IEnumerable<Rents> GetAll();
}