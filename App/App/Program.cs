using App.Container;
using App.Main.Gadgets;
using App.Main.Users;
using App.Service;
// using App.UI;

namespace App;

public static class Program
{
	public static void Main(string[] args)
	{
		var gadgetContainer = new GadgetContainer();
		var userContainer = new UserContainer();
		var rentContainer = new RentContainer();

		var rentService = new RentService(rentContainer, gadgetContainer, userContainer);

		var user1 = new Student(GenId.Generate(userContainer.GetAll()), "John", "Blue");
		userContainer.Add(user1);
		var user2 = new Employee(GenId.Generate(userContainer.GetAll()), "Alice", "Green");
		userContainer.Add(user2);

		var gadget1 = new Laptop(GenId.Generate(gadgetContainer.GetAll()), "Mega1", 16, true);
		gadgetContainer.Add(gadget1);
		var gadget2 = new Camera(GenId.Generate(gadgetContainer.GetAll()), "Mega2", 100, true);
		gadgetContainer.Add(gadget2);
		var gadget3 = new Projector(GenId.Generate(gadgetContainer.GetAll()), "Mega3", 100, 100);
		gadgetContainer.Add(gadget3);

		rentService.Rent(user1.Id, gadget2.Id, "22.03.2026 00:00:00");
		rentService.Return(user1.Id, gadget2.Id);

		Console.WriteLine();

		rentService.Rent(user2.Id, gadget1.Id, "01.01.2027 00:00:00");
		rentService.Return(user2.Id, gadget1.Id);

		Console.WriteLine();

		Console.WriteLine($"Gadgets: {gadgetContainer.GetAll().Count()}\n" +
		                  $"Type   ID   Model   Available");
		foreach (var gadget in gadgetContainer.GetAll())
			Console.WriteLine($"{gadget.GetType().Name} {gadget.Id} {gadget.Model} {gadget.IsAvailable}");
		Console.WriteLine();

		Console.WriteLine($"Users: {userContainer.GetAll().Count()}\n" +
		                  $"ID   Surname   Name");
		foreach (var user in userContainer.GetAll())
			Console.WriteLine($"{user.Id} {user.Surname} {user.Name}");
		Console.WriteLine();

		Console.WriteLine($"Rents: {rentContainer.GetAll().Count()}\n" +
		                  $"ID   User ID   Gadget ID      From              Until                  Returned");
		foreach (var rent in rentContainer.GetAll())
			Console.WriteLine($"{rent.Id}        {rent.UserId}        {rent.GadgetId}        {rent.Start} {rent.End} {rent.Returned}");
		Console.WriteLine();

		// Starter.Start(args, gadgetContainer, userContainer, rentContainer, rentService);
	}
}