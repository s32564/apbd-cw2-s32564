using App.Container;
using App.Main.Gadgets;
using App.Main.Users;

namespace App;

public static class Program
{
	public static void Main(string[] args)
	{
		var gadget1 = new Laptop(GenId.Generate(GadgetContainer.GetAll()), "Mega1", 16, true);
		GadgetContainer.Add(gadget1);
		var gadget2 = new Camera(GenId.Generate(GadgetContainer.GetAll()), "Mega2", 100, true);
		GadgetContainer.Add(gadget2);
		var gadget3 = new Projector(GenId.Generate(GadgetContainer.GetAll()), "Mega3", 100, 100);
		GadgetContainer.Add(gadget3);

		var single = GadgetContainer.GetSingle(2);
		Console.WriteLine(single);

		var user1 = new Student(GenId.Generate(UserContainer.GetAll()), "Jan", "Kowalski");
		UserContainer.Add(user1);
		var user2 = new Employee(GenId.Generate(UserContainer.GetAll()), "John", "Doe");
		UserContainer.Add(user2);
		var user3 = new Student(GenId.Generate(UserContainer.GetAll()), "Blue", "Green");
		UserContainer.Add(user3);


	}
}