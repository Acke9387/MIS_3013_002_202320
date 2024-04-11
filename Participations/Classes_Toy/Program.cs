using Classes_Toy;

List<Toy> toys = new List<Toy>();

Toy myToy = new Toy();

myToy.Name = "Switch";
myToy.Manufacturer = "Nintendo";
myToy.Price = 299.99;
myToy.SetNotes("Great fun for your kids!");

toys.Add(myToy);
//Console.WriteLine($"{myToy.Name} is made by {myToy.Manufacturer} and sells for {myToy.Price.ToString("C")}.\n {myToy.GetNotes()} ");

//Console.WriteLine(myToy);

Toy myToy2 = new Toy("Barbie", "Mattel", 30.00, "Great toy for your kid");

//Console.WriteLine(myToy2);

toys.Add(myToy2);

foreach (Toy toy in toys)
{
    Console.WriteLine(toy);
}