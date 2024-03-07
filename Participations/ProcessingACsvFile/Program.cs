using System.Globalization;

string[] allLinesOfFile = File.ReadAllLines("sales_data_sample.csv");

double salesFor2003 = 0;
double salesFor2004 = 0;
double salesFor2005 = 0;

double salesForJanuary = 0;
double[] salesByMonth = new double[13];

foreach (string line in allLinesOfFile.Skip(1))
{
    //            0             1             2           3           4       5       6       7       8        9       10
    //line : "ORDERNUMBER,QUANTITYORDERED,PRICEEACH,ORDERLINENUMBER,SALES,ORDERDATE,STATUS,QTR_ID,MONTH_ID,YEAR_ID,PRODUCTLINE,MSRP,PRODUCTCODE,CUSTOMERNAME,PHONE,ADDRESSLINE1,ADDRESSLINE2,CITY,STATE,POSTALCODE,COUNTRY,TERRITORY,CONTACTLASTNAME,CONTACTFIRSTNAME,DEALSIZE"
    string[] piecesOfLine = line.Split(",");
    //piecesOfLine[0] = "ORDERNUMBER"
    //piecesOfLine[1] = "QUANTITYORDERERD"
    //piecesOfLine[2] = "PRICEEACH"
    //piecesOfLine[3] = "ORDERLINENUMBER"

    string status = piecesOfLine[6];
    double sales = Convert.ToDouble(piecesOfLine[4]);

    if (status == "Shipped")
    {
        if (piecesOfLine[9] == "2003")
        {
            //salesFor2003 += Convert.ToDouble(piecesOfLine[4]);
            salesFor2003 += sales;
        }
        else if (piecesOfLine[9] == "2004")
        {
            salesFor2004 += sales;
        }
        else if (piecesOfLine[9] == "2005")
        {
            salesFor2005 += sales;
        }

        //if (piecesOfLine[8] == "1")
        //{
        //    salesForJanuary += sales;
        //}
        int month = Convert.ToInt32(piecesOfLine[8]);
        salesByMonth[month] += sales;

    }

}

Console.WriteLine($"The total sales for 2003 was {salesFor2003.ToString("C")}");
Console.WriteLine($"The total sales for 2004 was {salesFor2004.ToString("C")}");
Console.WriteLine($"The total sales for 2005 was {salesFor2005.ToString("C")}");
Console.WriteLine($"The total sales for all years was {(salesFor2003 + salesFor2004 + salesFor2005).ToString("C")}");

for (int i = 1; i < salesByMonth.Length; i++)
{
    string month = "";
    //if (i == 1)
    //{
    //    month = "January";
    //}
    month = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i);
    Console.WriteLine($"The total sales for all {month} is {salesByMonth[i].ToString("C")}");
}


//for (int i = 1; i < allLinesOfFile.Length; i++)
//{
//    Console.WriteLine(allLinesOfFile[i]);
//}