Random rand = new Random();
int randomNumber = rand.Next(1, 2 + 1);

const int HEADS = 1;
const int TAILS = 2;

// Used for testing purposes
//Console.WriteLine(randomNumber);

Console.WriteLine("Guess heads or tails? >>");
string userGuess = Console.ReadLine();

int usersGuessAsANumber;

if (userGuess == "heads")
{
    usersGuessAsANumber = HEADS;
}
else
{
    usersGuessAsANumber = TAILS;
}

if (randomNumber == HEADS)
{
    Console.WriteLine("It came up heads");
}
else
{
    Console.WriteLine("It came up tails");
}

if (randomNumber == usersGuessAsANumber)
{
    Console.WriteLine("Congratulations, you guessed correctly!");
}
else
{
    Console.WriteLine("Sorry, better luck next time!");
}