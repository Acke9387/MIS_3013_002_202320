
Console.WriteLine("Please enter your first number >>");
string answer = Console.ReadLine();
double num1 = Convert.ToDouble(answer);

Console.WriteLine("Please enter your second number >>");
answer = Console.ReadLine();
double num2 = Convert.ToDouble(answer);

Console.WriteLine("Please enter your third number >>");
double num3 = Convert.ToDouble(Console.ReadLine());

double total = num1 + num2 + num3;
Console.WriteLine($"The sum of {num1.ToString("N3")}, {num2.ToString("N3")}, and {num3.ToString("N3")} is {total.ToString("N3")}.");


const double MAGIC_NUMBER = 7.777;

double magicTotal = total * MAGIC_NUMBER;
Console.WriteLine($"The magic total is {magicTotal.ToString("N3")}.");

