using App.Container;
using App.Main;

namespace App.Service;

public class RentService(IRentContainer rents, IGadgetContainer gadgets, IUserContainer users)
    : IRentService
{

    public void Rent(int userId, int gadgetId, string dateToRet)
    {
        var user = users.GetSingle(userId);
        var gadget = gadgets.GetSingle(gadgetId);

        if (!gadget.IsAvailable)
        {
            Console.WriteLine("This gadget is not available.");
            return;
        }

        var active = users.GetMaxRents(userId);
        if (active >= user.MaxRents)
        {
            Console.WriteLine("This user has maximum rents.");
            return;
        }

        var rent = new Rents(
            GenId.Generate(rents.GetAll()),
            userId,
            gadgetId,
            DateTime.Parse("19.03.2026 00:00:00"),
            DateTime.Parse(dateToRet));
        gadget.SetUnavailable();
        rents.Add(rent);
        users.AddRent(userId);
    }

    public void Return(int userId, int gadgetId)
    {
        try
        {
            var allRents = rents.GetAll();
            foreach (var rent in allRents)
            {
                if (rent.UserId != userId || rent.GadgetId != gadgetId) continue;

                var gadget = gadgets.GetSingle(rent.GadgetId);
                var toPay = rent.Return(DateTime.Now);
                Console.WriteLine("You have successfully returned the rent!");
                if (toPay > 0)
                    Console.WriteLine($"You missed the date. You need to pay {toPay} PLN.");
                gadget.SetAvailable();
                users.RemoveRent(userId);
                break;
            }
        }
        catch (InvalidOperationException)
        {
            Console.WriteLine("There is no rent with this id.");
        }
    }
}