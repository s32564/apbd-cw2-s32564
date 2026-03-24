using App.Main.Users;

namespace App.Container;

public class UserContainer : IUserContainer
{
    private readonly List<Users> _users = [];

    public void Add(Users user) => _users.Add(user);

    public Users GetSingle(int id) => _users.First(g => g.Id == id);

    public IEnumerable<Users> GetAll() => _users;
}