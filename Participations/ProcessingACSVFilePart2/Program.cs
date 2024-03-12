/*
 * @Author Professor Ackerman
 * 
 * Notes: File.ReadAllLines("");
 * 
 */


using System.Diagnostics;
using System.Xml.Linq;

string[] linesOfFile = File.ReadAllLines("SalesJan2009.csv");
List<string> transactionDates = new List<string>();
List<string> names = new List<string>();
List<string> countries = new List<string>();
List<string> paymentTypes = new List<string>();
List<double> prices = new List<double>();

for (int i = 1; i < linesOfFile.Length; i++)
{
    string line = linesOfFile[i];
    string[] piecesOfLine = line.Split(",");
    //        0           1      2         3        4   5     6      7           8             9        10       11
    //Transaction_date,Product,Price,Payment_Type,Name,City,State,Country,Account_Created,Last_Login,Latitude,Longitude

    string transactionDate = piecesOfLine[0];
    string name = piecesOfLine[4];
    string country = piecesOfLine[7];
    string paymentType = piecesOfLine[3];
    double price = Convert.ToDouble(piecesOfLine[2]);

    //if (country.ToLower() == "united states" && paymentType.ToLower() == "visa")
    //{
    //    Console.WriteLine($"{name} made a purchase on {transactionDate} for {price.ToString("C")}");
    //}

    transactionDates.Add(transactionDate);
    names.Add(name);
    countries.Add(country);
    paymentTypes.Add(paymentType);
    prices.Add(price);
}



for (int i = 0; i < names.Count; i++)
{
    if (countries[i].ToLower() == "united states" && paymentTypes[i].ToLower() == "visa")
    {
        Console.WriteLine($"{names[i]} made a purchase on {transactionDates[i]} for {prices[i].ToString("C")}");
    }
}