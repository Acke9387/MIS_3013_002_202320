const string DEVELOPER_NAME = "Professor Ackerman";
string date = "4/4/24";

DeveloperInformation(DEVELOPER_NAME, "MIS 3013", date);

string response;
string previousInputAnswer = "no";
double answer = 0;
do
{
    Console.WriteLine("Do you want to Add, Subtract, Multiply or Divide? >>");
    string operation = Console.ReadLine().ToLower();
    double first;
    if (previousInputAnswer == "no")
    {
        Console.WriteLine("What is the first number ? >>");
        first = Convert.ToDouble(Console.ReadLine());
    }
    else
    {
        first = answer;
    }

    Console.WriteLine("What is the second number ? >>");
    double second = Convert.ToDouble(Console.ReadLine());

    answer = 0;
    string operand = "";
    if (operation == "add")
    {
        answer = Add(first, second);
        operand = "+";
    }
    else if (operation == "subtract")
    {
        answer = Subtract(first, second);
        operand = "-";
    }
    else if (operation == "multiply")
    {
        answer = Multiply(first, second);
        operand = "*";
    }
    else if (operation == "divide")
    {
        answer = Divide(first, second);
        operand = "/";
    }
    else
    {
        Console.WriteLine("Invalid operation.  goodbye");
        return;
    }


    Console.WriteLine($"{first.ToString("N")} {operand} {second.ToString("N")} = {answer.ToString("N")}");

    Console.WriteLine("Do you want to perform another operation? yes or no >>");
    response = Console.ReadLine().ToLower();
    if (response == "yes")
    {
        Console.WriteLine("Do you want to use the current result as the first input? yes or no>>");
        previousInputAnswer = Console.ReadLine().ToLower();
    }

} while (response == "yes");



double Add(double leftOperand, double rightOperand)
{
    double result = leftOperand + rightOperand;
    return result;
}

double Subtract(double leftOperand, double rightOperand)
{
    double result = leftOperand - rightOperand;
    return result;
}

double Multiply(double leftOperand, double rightOperand)
{
    double result = leftOperand * rightOperand;
    return result;
}

double Divide(double leftOperand, double rightOperand)
{
    double result = leftOperand / rightOperand;
    return result;
}

void DeveloperInformation(string devName, string className, string date)
{
    Console.WriteLine($"{devName} wrote this application on {date} for {className}");
}