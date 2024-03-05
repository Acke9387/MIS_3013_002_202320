string[] allLinesOfFile = File.ReadAllLines("sales_data_sample.csv");

double salesFor2003 = 0;
double salesFor2004 = 0;
double salesFor2005 = 0;

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
    }

}

Console.WriteLine($"The total sales for 2003 was {salesFor2003.ToString("C")}");


//for (int i = 1; i < allLinesOfFile.Length; i++)
//{
//    Console.WriteLine(allLinesOfFile[i]);
//}