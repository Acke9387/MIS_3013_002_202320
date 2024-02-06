//Ask the user to provide input for what number they want to count
//by as well as up to which number.
//
//E.g. I wish to count by 3 up to 10.
//The output would be "3, 6, 9"

Console.WriteLine("What would you like to count by? >>");
int countBy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What would you like to count up to? >>");
int countUpTo = Convert.ToInt32(Console.ReadLine());

int currentValue = countBy;

Console.WriteLine("\nWhile loop way:");
while (currentValue <= countUpTo)
{
    Console.WriteLine(currentValue.ToString("N0"));
    currentValue = currentValue + countBy;

    // Shorthand version
    //currentValue += countBy;
}

Console.WriteLine("\n\nFor loop way:");
for (int i = countBy; i <= countUpTo; i = i + countBy)
{
    Console.WriteLine(i.ToString("N0"));
}