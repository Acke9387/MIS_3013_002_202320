//Get input from user
Console.WriteLine(  "How many bank accounts do you have? >>");

// Get the user's response and store it in a variable
string answer = Console.ReadLine();

// Create a variable to store the converted value from their answer
int numberOfAccounts;

// Keep looping while their response is not a valid integer
while (int.TryParse(answer, out numberOfAccounts) == false)
{
    Console.WriteLine(  "Invalid number for accounts.  Please type a valid number.>>");
    answer = Console.ReadLine();
}

// Create an 'accumulating' variable to keep adding the balance
// of bank accounts to so we can get the total $
double total = 0;

// Loop numberOfAccounts number of times to get their balance for each account
for (int i = 0; i < numberOfAccounts; i++)
{
    Console.WriteLine($"What is your balance for bank account # {i.ToString("N")}");
    total += Convert.ToDouble(Console.ReadLine());
}

// Calculate the average bank account balance by dividing the total
// by the number of accounts
double average =  total / numberOfAccounts;

// Display the total to the user, formatted as 'c' - Currency
Console.WriteLine($"Your total for all accounts is {total.ToString("C")}");

// Check to see if their average is greater than 5000
// if it is, we want to color the text different
if (average > 5000)
{
    Console.BackgroundColor= ConsoleColor.Green;
    Console.ForegroundColor= ConsoleColor.Blue;
}
Console.WriteLine($"Your average for all your accounts is {average.ToString("C")}");
