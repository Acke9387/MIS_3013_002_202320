int[] studentIds = new int[3];
studentIds[0] = 1;
studentIds[1] = 2;
studentIds[2] = 3;

for (int i = 0; i < studentIds.Length; i++)
{
    studentIds[i] = i + 1;
}
//                 0    1    2
double[] gpas = { 3.0, 4.0, 2.7 };

for (int i = 0;i < gpas.Length; i++)
{
    Console.WriteLine($"Student with ID {studentIds[i].ToString("N0")} has a GPA of {gpas[i].ToString("N2")}");
}

gpas[2] = 3.7;
Console.WriteLine("\n");
for (int i = 0; i < gpas.Length; i++)
{
    Console.WriteLine($"Student with ID {studentIds[i].ToString("N0")} has a GPA of {gpas[i].ToString("N2")}");
}