
using Classes_ToyBox;

List<ToyBox> toyboxes = new List<ToyBox>();

do
{
    ToyBox tb = new ToyBox();
    Console.Write("Enter the owner's name >> ");
    tb.Owner = Console.ReadLine();

    Console.Write("Enter the location >> ");
    tb.Location = Console.ReadLine();

    do
    {
        Toy t = new Toy();
        Console.Write("Enter the toy name >> ");
        t.Name = Console.ReadLine();

        Console.Write("Enter the toy manufacturer >>");
        t.Manufacturer = Console.ReadLine();

        Console.WriteLine("Enter the price of the toy >>");
        t.Price = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the notes for the toy >>");
        t.SetNotes(Console.ReadLine());

        tb.Toys.Add(t);
        Console.WriteLine("Do you have another Toy to add to the ToyBox? yes or no >>");
    } while (Console.ReadLine().ToLower()[0] == 'y');

    toyboxes.Add(tb);
    Console.WriteLine("Do you have another ToyBox to enter? yes or no >>");
} while (Console.ReadLine().ToLower()[0] == 'y');



foreach (ToyBox toyBox in toyboxes)
{
    Console.WriteLine($"This ToyBox is owned by {toyBox.Owner} and is located at {toyBox.Location}");
    Console.WriteLine($"A random toy from this toybox is {toyBox.GetRandomToy()}");
}