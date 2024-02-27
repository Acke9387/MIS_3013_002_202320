Dictionary<int, double> studentGrades = new Dictionary<int, double>();

studentGrades.Add(1000, 3.0);
studentGrades.Add(2000, 4.0);
studentGrades.Add(3000, 2.7);

foreach (int studentID in studentGrades.Keys)
{
    Console.WriteLine($"Student with ID {studentID.ToString("N0")} has a GPA of {studentGrades[studentID].ToString("N2")}");
}

string answer = "yes";
while (answer.ToLower() == "yes")
{
    Console.WriteLine("Would you like to add another student? yes or no >>");
    answer = Console.ReadLine().ToLower();
    if (answer == "yes")
    {
        Console.WriteLine("What is the student's ID? >>");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the GPA of the student? >>");
        double gpa = Convert.ToDouble(Console.ReadLine());

        if (studentGrades.ContainsKey(id) == false)
        {
            studentGrades.Add(id, gpa);
        }
        else
        {
            // business decision

            studentGrades[id] = gpa;
        }
    } 
}


Console.WriteLine("\n");
foreach (int studentID in studentGrades.Keys)
{
    Console.WriteLine($"Student with ID {studentID.ToString("N0")} has a GPA of {studentGrades[studentID].ToString("N2")}");
}