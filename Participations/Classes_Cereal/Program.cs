
using Classes_Cereal;

string[] linesOfFile = File.ReadAllLines("Cereal_Data.txt");

List<Cereal> cereals = new List<Cereal>();

for (int i = 1; i < linesOfFile.Length; i++)
{
    //name|manufacturer|calories|cups 
    string[] pieces = linesOfFile[i].Split('|');
    Cereal c = new Cereal();
    c.Name = ....;

    cereals.Add(c);
}

Console.WriteLine("Cereals with serving size of 1 cup or more");
foreach (Cereal cereal in cereals)
{
    if ()
    {

    }
}

Console.WriteLine("Cereals with 100 calories or less per serving");
foreach (Cereal cereal in cereals)
{
    if ()
    {

    }
}