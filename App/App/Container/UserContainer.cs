using App.Main.Users;

namespace App.Container;

public class UserContainer : IUserContainer
{
    private readonly List<Users> _users = [];
    private readonly Dictionary<int, int> _rentCounter = new();

    public void Add(Users user) => _users.Add(user);

    public Users GetSingle(int id) => _users.First(g => g.Id == id);

    public IEnumerable<Users> GetAll() => _users;

    public int GetMaxRents(int userId) => _rentCounter.GetValueOrDefault(userId, 0);

    public void AddRent(int userId)
    {
        if (!_rentCounter.TryAdd(userId, 1))
            _rentCounter[userId]++;
    }

    public void RemoveRent(int userId)
    {
        _rentCounter[userId]--;
    }
}