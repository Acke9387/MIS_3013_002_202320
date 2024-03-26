
List<string> names = new List<string>();
List<double> salePrices = new List<double>();
List<double> msrps = new List<double>();
List<string> manufacturers = new List<string>();
List<string> categories = new List<string>();
List<string> colors = new List<string>();
List<double> weights = new List<double>();

string[] allLinesOfFile = File.ReadAllLines("product_information.txt");

for (int i = 1; i < allLinesOfFile.Length; i++)
{
    string[] piecesOfLine = allLinesOfFile[i].Split("|");
    //      0            1         2          3                 4                5                6
    //product_name | sale_price | msrp | manufacturer | product_category | product_color | product_weight

    names.Add(piecesOfLine[0]);
    salePrices.Add(Convert.ToDouble(piecesOfLine[1]));
    msrps.Add(Convert.ToDouble(piecesOfLine[2]));
    manufacturers.Add(piecesOfLine[3]);
    categories.Add(piecesOfLine[4]);
    colors.Add(piecesOfLine[5]);
    weights.Add(Convert.ToDouble(piecesOfLine[6]));
}

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine("".PadLeft(25, '*'));
    Console.WriteLine($"Product Name : {names[i]}");
    Console.WriteLine($"Sale Price: {salePrices[i].ToString("C")}");
    Console.WriteLine($"MSRP: {msrps[i].ToString("C")}");
    Console.WriteLine($"Manufacturer: {manufacturers[i]}");
    Console.WriteLine($"Category : {categories[i]}");
    Console.WriteLine($"Color : {colors[i]}");
    Console.WriteLine($"Weight : {weights[i].ToString("N")}");
    Console.WriteLine("".PadLeft(25, '*'));
    Console.WriteLine();
}


double salesAverage = CalculateAverage(salePrices);
Console.WriteLine($"The average for sale prices is {salesAverage.ToString("C")}");

double msrpAverage = CalculateAverage(msrps);
Console.WriteLine($"The average for msrp is {msrpAverage.ToString("C")}");


///<summary>Calculates the average of a list of double</summary>
double CalculateAverage(List<double> values)
{
    double average = 0;
    double total = 0;
    foreach (double value in values)
    {
        total += value;
    }

    average = total / values.Count;
    return average;
}


//double salesTotal = 0;
//foreach (double sales in salePrices) 
//{
//    salesTotal += sales;
//}
//double salesAverage = salesTotal / salePrices.Count;

//double msrpTotal = 0;
//foreach (double msrp in msrps)
//{
//    msrpTotal += msrp;
//}
//double msrpAverage = msrpTotal / msrps.Count;
