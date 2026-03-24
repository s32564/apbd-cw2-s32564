using App.Main.Users;

namespace App.Container;

public interface IUserContainer
{
    void Add(Users users);
    Users GetSingle(int id);
    IEnumerable<Users> GetAll();
}