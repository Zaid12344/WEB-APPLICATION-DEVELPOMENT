class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public int Semester { get; set; }
    public int Age { get; set; }
    public double CGPA { get; set; }

}
class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();
        students.Add(new Student
        {
            Id = 43,
            Name = "Tony",
            Department = "CE",
            Semester = 5,
            Age = 19,
            CGPA = 8.3
        });

        students.Add(new Student
        {
            Id = 56,
            Name = "Steve",
            Department = "CH",
            Semester = 5,
            Age = 19,
            CGPA = 9.6
        });

        students.Add(new Student
        {
            Id = 77,
            Name = "Thor",
            Department = "MH",
            Semester = 5,
            Age = 19,
            CGPA = 9.2
        });

        students.Add(new Student
        {
            Id = 32,
            Name = "Peter",
            Department = "IT",
            Semester = 8,
            Age = 27,
            CGPA = 10
        });

        students.Add(new Student
        {
            Id = 99,
            Name = "Bruce",
            Department = "CH",
            Semester = 7,
            Age = 37,
            CGPA = 9.99
        });

        students.Add(new Student
        {
            Id = 89,
            Name = "Richard",
            Department = "EC",
            Semester = 6,
            Age = 32,
            CGPA = 9.0
        });


        var result1 = from st in students
                      where st.CGPA >= 8.0
                      select st.Name;

        Console.WriteLine(": Result 1 : ");
        foreach (var r1 in result1) { Console.WriteLine(r1); }
        Console.WriteLine();

        var result2 = from st in students
                      where st.Department == "CE"
                      orderby st.CGPA descending
                      select st;

        Console.WriteLine(": Result 2 : ");
        foreach (var st in result2)
        {
            Console.WriteLine(
            $"Name : {st.Name} \n" + $"Department : {st.Department} \n" + $"CGPA : {st.CGPA}"
            );
        }
        Console.WriteLine();

        var result3 = (from st in students
                       orderby st.CGPA descending
                       select st.Name).Take(3);

        Console.WriteLine(": Result 3 : ");
        foreach (var r3 in result3) { Console.WriteLine(r3); }
        Console.WriteLine();

        var MH = from st in students
                 where st.Department == "MH"
                 select st;

        var CH = from st in students
                 where st.Department == "CH"
                 select st;

        var CE = from st in students
                 where st.Department == "CE"
                 select st;

        var EC = from st in students
                 where st.Department == "EC"
                 select st;

        var IT = from st in students
                 where st.Department == "IT"
                 select st;

        Console.WriteLine(": Result 4 : ");
        Console.WriteLine("count of students in Mechanical Department : " + MH.Count());
        Console.WriteLine("count of students in Computer Department : " + CE.Count());
        Console.WriteLine("count of students in Chemical Department : " + CH.Count());
        Console.WriteLine("count of students in Electronic Communication Department : " + EC.Count());
        Console.WriteLine("count of students in Information Technology Department : " + IT.Count());
        Console.WriteLine();
    }
}
