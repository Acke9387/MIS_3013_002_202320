using System;

Random r = new Random();

Console.WriteLine("Please provide the minimum number >>");
//int min = Convert.ToInt32(Console.ReadLine());
string answer = Console.ReadLine();
int min;

bool isValidNumber = int.TryParse(answer, out min);

while (isValidNumber == false)
{
    Console.WriteLine("Invalid number for Minimum, please try again>>");
    answer = Console.ReadLine();
    isValidNumber = int.TryParse(answer, out min);
}

Console.WriteLine("Please provide the Maximum number >>");
//int max = Convert.ToInt32(Console.ReadLine());
answer = Console.ReadLine();
int max;
isValidNumber = int.TryParse(answer, out max);
while (isValidNumber == false)
{
    Console.WriteLine("Invalid number for Maximum, please try again>>");
    answer = Console.ReadLine();
    isValidNumber = int.TryParse(answer, out max);
}

// Totally blanked on how to let the user define the min/max
//int randomNumber = r.Next(Console.ReadLine());
int randomNumber = r.Next(min, max + 1);

//Console.WriteLine("Please make a guess >>");
int guess;// = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(randomNumber);
do
{
    Console.WriteLine("Please make a guess >>");
    guess = Convert.ToInt32(Console.ReadLine());

} while (randomNumber != guess);

Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine("Congratulations, you guessed correctly.");
Console.WriteLine();
