using App.Main.Users;

namespace App.Container;

public class UserContainer
{
    private static readonly List<Users> Users = [];

    public static void Add(Users gadget) => Users.Add(gadget);

    public static Users GetSingle(int id) => Users.First(g => g.Id == id);

    public static IEnumerable<Users> GetAll() => Users;
}