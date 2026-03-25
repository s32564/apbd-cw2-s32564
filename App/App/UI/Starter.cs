// using App.Container;
// using App.Main.Gadgets;
// using App.Main.Users;
// using App.Service;
//
// namespace App.UI;
//
// public static class Starter
// {
// 	public static void Start(string[] args,
// 		GadgetContainer gadgetContainer,
// 		UserContainer userContainer,
// 		RentContainer rentContainer,
// 		RentService rentService)
// 	{
// 		if (args[0].Equals("add", StringComparison.CurrentCultureIgnoreCase))
// 			Add(args, userContainer, gadgetContainer);
// 		else if (args[0].Equals("list", StringComparison.CurrentCultureIgnoreCase))
// 			List(args, gadgetContainer, rentContainer);
// 		else if (args[0].Equals("rent", StringComparison.CurrentCultureIgnoreCase))
// 			Rent(args, userContainer, gadgetContainer, rentService);
// 		else if (args[0].Equals("return", StringComparison.CurrentCultureIgnoreCase))
// 			Return(args, userContainer, gadgetContainer, rentService);
// 		else if (args[0].Equals("disable", StringComparison.CurrentCultureIgnoreCase))
// 			Disable(args, gadgetContainer);
// 		else if (args[0].Equals("show", StringComparison.CurrentCultureIgnoreCase))
// 			Show(args, userContainer, rentContainer, gadgetContainer);
// 		else if (args[0].Equals("raport", StringComparison.CurrentCultureIgnoreCase))
// 			Raport(userContainer, rentContainer, gadgetContainer);
// 	}
//
// 	private static void Add(string[] args, UserContainer userContainer, GadgetContainer gadgetContainer)
// 	{
// 		if (args[1].Equals("user", StringComparison.CurrentCultureIgnoreCase))
// 		{
// 			var id = GenId.Generate(userContainer.GetAll());
// 			string? name = null;
// 			string? surname = null;
// 			string? role = null;
//
// 			foreach (var arg in args)
// 			{
// 				if (arg.Split("=")[0].Equals("name", StringComparison.CurrentCultureIgnoreCase))
// 					name = arg.Split("=")[1];
// 				else if (arg.Split("=")[0].Equals("surname",  StringComparison.CurrentCultureIgnoreCase))
// 					surname = arg.Split("=")[1];
// 				else if (arg.Split("=")[0].Equals("role",  StringComparison.CurrentCultureIgnoreCase))
// 					role = arg.Split("=")[1];
// 			}
//
// 			if (role != null && name != null && surname != null)
// 			{
// 				if (role.Equals("student", StringComparison.CurrentCultureIgnoreCase))
// 				{
// 					var student = new Student(id, name, surname);
// 					userContainer.Add(student);
// 					Console.WriteLine($"A student {surname} {name} has been added.");
// 				}
// 				else if (role.Equals("employee", StringComparison.CurrentCultureIgnoreCase))
// 				{
// 					var employee = new Employee(id, name, surname);
// 					userContainer.Add(employee);
// 					Console.WriteLine($"An employee {surname} {name} has been added.");
// 				}
// 			} else
// 				Console.WriteLine("Role, name and username must be provided.");
// 		} else if (args[1].Equals("gadget",  StringComparison.CurrentCultureIgnoreCase))
// 		{
// 			var id = GenId.Generate(gadgetContainer.GetAll());
// 			string? model = null;
// 			string? quality = null;
// 			string? withNightMode = null;
// 			string? ram = null;
// 			string? ssd = null;
// 			string? resolution = null;
// 			string? lumens = null;
// 			string? type = null;
//
// 			foreach (var arg in args)
// 			{
// 				if (arg.Split("=")[0].Equals("model", StringComparison.CurrentCultureIgnoreCase))
// 					model = arg.Split("=")[1];
// 				else if (arg.Split("=")[0].Equals("quality", StringComparison.CurrentCultureIgnoreCase))
// 					quality = arg.Split("=")[1];
// 				else if (arg.Split("=")[0].Equals("night", StringComparison.CurrentCultureIgnoreCase))
// 					withNightMode = arg.Split("=")[1];
// 				else if (arg.Split("=")[0].Equals("ram", StringComparison.CurrentCultureIgnoreCase))
// 					ram = arg.Split("=")[1];
// 				else if (arg.Split("=")[0].Equals("ssd", StringComparison.CurrentCultureIgnoreCase))
// 					ssd = arg.Split("=")[1];
// 				else if (arg.Split("=")[0].Equals("resolution", StringComparison.CurrentCultureIgnoreCase))
// 					resolution = arg.Split("=")[1];
// 				else if (arg.Split("=")[0].Equals("bright", StringComparison.CurrentCultureIgnoreCase))
// 					lumens = arg.Split("=")[1];
// 				else if (arg.Split("=")[0].Equals("type", StringComparison.CurrentCultureIgnoreCase))
// 					type = arg.Split("=")[1];
// 			}
//
// 			if (type != null && model != null)
// 			{
// 				if (type.Equals("laptop", StringComparison.CurrentCultureIgnoreCase))
// 				{
// 					if (ram != null && ssd != null)
// 					{
// 						var laptop = new Laptop(id, model, int.Parse(ram), bool.Parse(ssd));
// 						gadgetContainer.Add(laptop);
// 						Console.WriteLine($"A laptop {model} with RAM={ram} and SSD={ssd} has been added.");
// 					}
// 					else
// 						Console.WriteLine("Ram size (in GB) and SSD/HDD (true/false) must be provided.");
// 				} else if (type.Equals("camera", StringComparison.CurrentCultureIgnoreCase))
// 				{
// 					if (quality != null && withNightMode != null)
// 					{
// 						var camera = new Camera(id, model, int.Parse(quality), bool.Parse(withNightMode));
// 						gadgetContainer.Add(camera);
// 						Console.WriteLine($"A camera {model} with quality={quality} MP and night mode={withNightMode} has been added.");
// 					}
// 					else
// 						Console.WriteLine("Quality (MP) and possibility of night mode (true/false) must be provided.");
// 				} else if (type.Equals("projector", StringComparison.CurrentCultureIgnoreCase))
// 				{
// 					if (lumens != null && resolution != null)
// 					{
// 						var projector = new Projector(id, model, int.Parse(resolution), int.Parse(lumens));
// 						gadgetContainer.Add(projector);
// 						Console.WriteLine($"A projector {model} with resolution={resolution} and brightness={lumens} lumens has been added.");
// 					}
// 					else
// 						Console.WriteLine("Resolution and brightness (lumen) must be provided.");
// 				}
// 			}
// 			else
// 				Console.WriteLine("At least type and model must be provided.");
// 		}
// 		else
// 			Console.WriteLine("Unknown object to add.");
// 	}
//
// 	private static void List(string[] args, GadgetContainer gadgetContainer, RentContainer rentContainer)
// 	{
// 		if (args[1].Equals("all", StringComparison.CurrentCultureIgnoreCase))
// 		{
// 			foreach (var gadget in gadgetContainer.GetAll())
// 				Console.WriteLine($"{gadget.GetType().Name} {gadget.Model}, available={gadget.IsAvailable}");
// 		}
// 		else if (args[1].Equals("available", StringComparison.CurrentCultureIgnoreCase))
// 		{
// 			foreach (var gadget in gadgetContainer.GetAll())
// 			{
// 				if (gadget.IsAvailable)
// 					Console.WriteLine($"{gadget.GetType().Name} {gadget.Model} is available.");
// 			}
// 		}
// 		else if (args[1].Equals("missing", StringComparison.CurrentCultureIgnoreCase))
// 		{
// 			foreach (var rent in rentContainer.GetAll())
// 			{
// 				if (rent.End >= DateTime.Now) continue;
// 				var missingGadget = gadgetContainer.GetSingle(rent.GadgetId);
// 				Console.WriteLine($"{missingGadget.GetType().Name} {missingGadget.Model} is missing.");
// 			}
// 		}
// 		else
// 			Console.WriteLine("Unknown parameter to list.");
// 	}
//
// 	private static void Rent(string[] args, UserContainer userContainer, GadgetContainer gadgetContainer,  RentService rentService)
// 	{
// 		string? model = null;
// 		string? type = null;
// 		string? name = null;
// 		string? surname = null;
//
// 		var gadgetId = 0;
// 		var userId = 0;
// 		var days = 7;
//
// 		foreach (var arg in args)
// 		{
// 			if (arg.Split("=")[0].Equals("model", StringComparison.CurrentCultureIgnoreCase))
// 				model = arg.Split("=")[1];
// 			else if (arg.Split("=")[0].Equals("type", StringComparison.CurrentCultureIgnoreCase))
// 				type = arg.Split("=")[1];
// 			else if (arg.Split("=")[0].Equals("name", StringComparison.CurrentCultureIgnoreCase))
// 				name = arg.Split("=")[1];
// 			else if (arg.Split("=")[0].Equals("surname", StringComparison.CurrentCultureIgnoreCase))
// 				surname = arg.Split("=")[1];
// 			else if (arg.Split("=")[0].Equals("days", StringComparison.CurrentCultureIgnoreCase))
// 				days = int.Parse(arg.Split("=")[1]);
// 		}
//
// 		if (model != null && type != null && name != null && surname != null)
// 		{
// 			foreach (var gadget in gadgetContainer.GetAll())
// 			{
// 				if (!gadget.IsAvailable) continue;
//
// 				if (gadget.Model.Equals(model, StringComparison.CurrentCultureIgnoreCase)
// 				    && gadget.GetType().Name.Equals(type, StringComparison.CurrentCultureIgnoreCase))
// 				{
// 					gadgetId = gadget.Id;
// 					break;
// 				}
//
// 				Console.WriteLine("There is no provided gadget or gadget is not available.");
// 				return;
// 			}
//
// 			foreach (var user in userContainer.GetAll())
// 			{
// 				if (user.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)
// 				    && user.Surname.Equals(surname, StringComparison.CurrentCultureIgnoreCase))
// 				{
// 					userId = user.Id;
// 					break;
// 				}
//
// 				Console.WriteLine("Provided user does not exist.");
// 				return;
// 			}
// 		}
//
// 		rentService.Rent(userId, gadgetId, days);
// 		Console.WriteLine($"The {type} {model} was rented to {surname} {name} for {days} days.");
// 	}
//
// 	private static void Return(string[] args, UserContainer userContainer, GadgetContainer gadgetContainer,
// 		RentService rentService)
// 	{
// 		string? model = null;
// 		string? type = null;
// 		string? name = null;
// 		string? surname = null;
//
// 		var gadgetId = 0;
// 		var userId = 0;
//
// 		foreach (var arg in args)
// 		{
// 			if (arg.Split("=")[0].Equals("model", StringComparison.CurrentCultureIgnoreCase))
// 				model = arg.Split("=")[1];
// 			else if (arg.Split("=")[0].Equals("type", StringComparison.CurrentCultureIgnoreCase))
// 				type = arg.Split("=")[1];
// 			else if (arg.Split("=")[0].Equals("name", StringComparison.CurrentCultureIgnoreCase))
// 				name = arg.Split("=")[1];
// 			else if (arg.Split("=")[0].Equals("surname", StringComparison.CurrentCultureIgnoreCase))
// 				surname = arg.Split("=")[1];
// 		}
//
// 		if (model != null && type != null && name != null && surname != null)
// 		{
// 			foreach (var gadget in gadgetContainer.GetAll())
// 			{
// 				if (gadget.IsAvailable) continue;
//
// 				if (gadget.Model.Equals(model, StringComparison.CurrentCultureIgnoreCase)
// 				    && gadget.GetType().Name.Equals(type, StringComparison.CurrentCultureIgnoreCase))
// 				{
// 					gadgetId = gadget.Id;
// 					break;
// 				}
//
// 				Console.WriteLine("There is no provided gadget or gadget is not rented.");
// 				return;
// 			}
//
// 			foreach (var user in userContainer.GetAll())
// 			{
// 				if (user.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)
// 				    && user.Surname.Equals(surname, StringComparison.CurrentCultureIgnoreCase))
// 				{
// 					userId = user.Id;
// 					break;
// 				}
//
// 				Console.WriteLine("Provided user does not exist.");
// 				return;
// 			}
// 		}
//
// 		rentService.Return(userId, gadgetId);
// 	}
//
// 	private static void Disable(string[] args, GadgetContainer gadgetContainer)
// 	{
// 		string? model = null;
// 		string? type = null;
//
// 		foreach (var arg in args)
// 		{
// 			if (arg.Split("=")[0].Equals("model", StringComparison.CurrentCultureIgnoreCase))
// 				model = arg.Split("=")[1];
// 			else if (arg.Split("=")[0].Equals("type", StringComparison.CurrentCultureIgnoreCase))
// 				type = arg.Split("=")[1];
// 		}
//
// 		if (model != null && type != null)
// 		{
// 			foreach (var gadget in gadgetContainer.GetAll())
// 			{
// 				if (gadget.Model.Equals(model, StringComparison.CurrentCultureIgnoreCase)
// 				    && gadget.GetType().Name.Equals(type, StringComparison.CurrentCultureIgnoreCase))
// 				{
// 					if (!gadget.IsAvailable)
// 					{
// 						Console.WriteLine("This gadget cannot be disabled now.");
// 						break;
// 					}
//
// 					gadget.SetUnavailable();
// 					Console.WriteLine($"{gadget.GetType().Name} {gadget.Model} was disabled.");
// 				}
// 			}
// 		}
// 		else
// 			Console.WriteLine("Type and model must be provided.");
// 	}
//
// 	private static void Show(string[] args, UserContainer userContainer, RentContainer rentContainer,
// 		GadgetContainer gadgetContainer)
// 	{
// 		string? name =  null;
// 		string? surname = null;
//
// 		var userId = 0;
//
// 		foreach (var arg in args)
// 		{
// 			if (arg.Split("=")[0].Equals("name", StringComparison.CurrentCultureIgnoreCase))
// 				name = arg.Split("=")[1];
// 			else if (arg.Split("=")[0].Equals("surname", StringComparison.CurrentCultureIgnoreCase))
// 				surname = arg.Split("=")[1];
// 		}
//
// 		if (name != null && surname != null)
// 		{
// 			foreach (var user in userContainer.GetAll())
// 			{
// 				if (user.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase)
// 				    && user.Surname.Equals(surname, StringComparison.CurrentCultureIgnoreCase))
// 					userId = user.Id;
// 				else
// 				{
// 					Console.WriteLine("Provided user does not exist.");
// 					return;
// 				}
// 			}
// 		}
// 		else
// 		{
// 			Console.WriteLine("Name and surname must be provided.");
// 			return;
// 		}
//
// 		Console.WriteLine($"{surname} {name} has:");
// 		foreach (var rent in rentContainer.GetAll())
// 		{
// 			if (rent.UserId != userId) continue;
// 			var model = gadgetContainer.GetSingle(rent.GadgetId).Model;
// 			var type = gadgetContainer.GetSingle(rent.GadgetId).GetType().Name;
// 			Console.WriteLine($"{type} {model}");
// 		}
// 	}
//
// 	private static void Raport(UserContainer userContainer, RentContainer rentContainer, GadgetContainer gadgetContainer)
// 	{
// 		Console.WriteLine($"Gadgets: {gadgetContainer.GetAll().Count()}\n" +
// 		                  $"Type   ID   Model   Available");
// 		foreach (var gadget in gadgetContainer.GetAll())
// 			Console.WriteLine($"{gadget.GetType().Name} {gadget.Id} {gadget.Model} {gadget.IsAvailable}");
// 		Console.WriteLine();
//
// 		Console.WriteLine($"Users: {userContainer.GetAll().Count()}\n" +
// 		                  $"ID   Surname   Name");
// 		foreach (var user in userContainer.GetAll())
// 			Console.WriteLine($"{user.Id} {user.Surname} {user.Name}");
// 		Console.WriteLine();
//
// 		Console.WriteLine($"Rents: {rentContainer.GetAll().Count()}\n" +
// 		                  $"ID   User ID   Gadget ID      From              Until                  Returned");
// 		foreach (var rent in rentContainer.GetAll())
// 			Console.WriteLine($"{rent.Id}        {rent.UserId}        {rent.GadgetId}        {rent.Start} {rent.End} {rent.Returned}");
// 		Console.WriteLine();
// 	}
// }