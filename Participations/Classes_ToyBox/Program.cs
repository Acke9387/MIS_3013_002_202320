
using Classes_ToyBox;

Toy t1 = new Toy("Buzz", "Disney", 45.43, "Up up and away!");

ToyBox tb = new ToyBox();

tb.Toys.Add(t1);


/// do not copy anything below this i am just playing around


int x = 3;

//convert x to binary
string[] binaryValues = { "01100010", "01101001", "01110100", "01101100", "01111001", "01100100", "01110110", "01101110" };
//convert b to ascii programmatically

string asciiString = string.Empty;
foreach (string binary in binaryValues)
{
    int number = Convert.ToInt32(binary, 2);
    asciiString += (char)number;
}
Console.WriteLine(asciiString);

