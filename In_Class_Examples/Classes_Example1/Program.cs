using Classes_Example1;

Rectangle r = new Rectangle();
r.Width = 5;
r.Length = 4;

Rectangle r1 = new Rectangle();
r1.Width = 90;
r1.Length = 2;
//r1.Message = "";

Console.WriteLine($"The area of rectangle r is {r.CalculateArea()}");

double r1Perimeter = r1.CalculatePerimeter();

Console.WriteLine($"The area of rectangle r1 is {r1Perimeter}");