/*Welcome the user to your application and prompt the user to enter
their name.

Prompt the user, while using their name, for their total monthly income
as well as their total monthly expenses.

Output the difference between the two values.*/

Console.WriteLine("Welcome to my application!");

Console.WriteLine("What is your name? >>");
string name = Console.ReadLine();


//Console.WriteLine($"Hello {name}! What is your monthly income? >>");
Console.WriteLine("Hello " + name + "! What is your monthly income? >>");
string incomeAsString = Console.ReadLine();
double income = Convert.ToDouble(incomeAsString);

Console.WriteLine($"Hello {name}! What is your monthly expenses? >>");
double expenses = Convert.ToDouble(Console.ReadLine());

double net = income - expenses;

Console.WriteLine($"The different of your income and expenses is {net.ToString("C5")}");