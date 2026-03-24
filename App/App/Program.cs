using App.Container;
using App.Main.Gadgets;
using App.Main.Users;
using App.Service;

namespace App;

public static class Program
{
	public static void Main(string[] args)
	{
		var gadgetContainer = new GadgetContainer();
		var userContainer = new UserContainer();
		var rentContainer = new RentContainer();

		var rentService = new RentService(rentContainer, gadgetContainer, userContainer);

		var gadget1 = new Laptop(GenId.Generate(gadgetContainer.GetAll()), "Mega1", 16, true);
		gadgetContainer.Add(gadget1);
		var gadget2 = new Camera(GenId.Generate(gadgetContainer.GetAll()), "Mega2", 100, true);
		gadgetContainer.Add(gadget2);
		var gadget3 = new Projector(GenId.Generate(gadgetContainer.GetAll()), "Mega3", 100, 100);
		gadgetContainer.Add(gadget3);

		var single = gadgetContainer.GetSingle(2);
		Console.WriteLine(single);

		var user1 = new Student(GenId.Generate(userContainer.GetAll()), "Jan", "Kowalski");
		userContainer.Add(user1);
		var user2 = new Employee(GenId.Generate(userContainer.GetAll()), "John", "Doe");
		userContainer.Add(user2);
		var user3 = new Student(GenId.Generate(userContainer.GetAll()), "Blue", "Green");
		userContainer.Add(user3);


		rentService.Rent(user1.Id, gadget1.Id, 2);
		rentService.Rent(user1.Id, gadget2.Id, 2);
		rentService.Rent(user1.Id, gadget3.Id, 2);
		rentService.Return(user1.Id,  gadget1.Id);
	}
}