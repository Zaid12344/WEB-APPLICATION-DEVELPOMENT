
Console.WriteLine("Grade Calculator!");
Console.WriteLine("Enter marks of subject :");
int[] marks = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.Write($"Subject {i + 1}: ");
    marks[i] = Convert.ToInt32(Console.ReadLine());
}

double average = marks.Average();
Console.WriteLine($"Average marks: {average}");
Console.WriteLine("Result : ");

string grade = average switch
{
    >= 90 => "AA",
    >= 80 => "AB",
    >= 70 => "BB",
    >= 60 => "BC",
    >= 50 => "CC",
    >= 40 => "CD",
    _ => "FF"
};
Console.WriteLine(grade);