
using Classes_Cereal;

string[] linesOfFile = File.ReadAllLines("Cereal_Data.txt");

List<Cereal> cereals = new List<Cereal>();

for (int i = 1; i < linesOfFile.Length; i++)
{
    //name|manufacturer|calories|cups 

    Cereal c = new Cereal();
    

    cereals.Add(c);
}

foreach (Cereal cereal in cereals)
{

}