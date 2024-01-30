//We are writing an application for a shipping company to provide quotes to
//vendors to ship their products. In order to calculate our quote,
//we need to know the :
//  total weight of the shipment in pounds,
//  the distance in miles and
//  whether or not there are hazardous materials in the shipment (e.g. batteries).
//
//The calculation for the quote is as follows:
//  Quote = .55 * # of miles + .73 * # of pounds
//If there is hazardous materials in the shipment, there is an extra cost of
//  .15 * # of pounds
//If the distance for the delivery is less
//than 150 miles and the total weight for the shipment is greater than 500 pounds,
//  then there should be a 10% discount off of the total quote
//
//Output all of the calculated values, discounts should be green, additional costs should be red

Console.WriteLine("How much does your shipment weigh, in pounds? >>");
double weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("How far do you need your shipment delivered, in miles? >>");
double miles = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Does your shipment contain hazardous material? yes or no >>");
string hazardousMaterial = Console.ReadLine();

double quote = (.55 * miles) + (.73 * weight);
double discount;
double hazardousCost = 0;

if (miles < 150 && weight > 500)
{
    discount = quote * .10;
}
else
{
    discount = 0;
}

if ( hazardousMaterial == "yes")
{
    hazardousCost = weight * .15;
}

Console.WriteLine($"Your initial quote for your shipment is {quote.ToString("C")}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Discount: {discount.ToString("C")}");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Expenses: {hazardousCost.ToString("C")}");

Console.ForegroundColor = ConsoleColor.White;
double finalQuote = quote - discount + hazardousCost;
Console.WriteLine("_________________________________");
Console.WriteLine($"Your final quote for your shipment is {finalQuote.ToString("C")}");