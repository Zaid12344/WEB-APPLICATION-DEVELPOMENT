
Console.WriteLine(" : Welcome to student list management : ");
Console.WriteLine();
List<string> students = new List<string>();


while (true)
{
    Console.WriteLine("Select the Operation :");
    Console.WriteLine("1. Add a new student name\n" +
        "2. Display all student names\n" +
        "3. Search for a student name\n" +
        "4. Update an existing student name\n" +
        "5. Delete a student name\n" +
        "6. Exit the application\n");


    int operation = Convert.ToInt32(Console.ReadLine());
    if (operation == 6)
    {
        Console.WriteLine("Successfully Exited :::");
        break;
    }
    switch (operation)
    {
        case 1:
            {
                Console.WriteLine("Enter Student Name : ");
                string studentName = Console.ReadLine() ?? string.Empty;
                students.Add(studentName);
                Console.WriteLine("Student Added Successfully");
                Console.WriteLine();
                break;
            }

        case 2:
            {
                Console.WriteLine("All Students : ");
                foreach (string student in students) Console.WriteLine(student);
                Console.WriteLine();
                break;
            }

        case 3:
            {
                Console.WriteLine("Enter the required student name :");
                string studentName = Console.ReadLine() ?? string.Empty;
                Console.WriteLine("Student list if found : ");
                List<string> found = students.FindAll(f => f == studentName);
                foreach (var student in found) { Console.WriteLine(student); }
                Console.WriteLine();
                break;
            }

        case 4:
            {
                Console.WriteLine("Enter the existing student name from below :");
                Console.WriteLine();
                foreach (string student in students) Console.WriteLine(student);
                Console.WriteLine();

                string existingName = Console.ReadLine() ?? string.Empty;
                int index = students.IndexOf(existingName);
                if (index == -1)
                {
                    Console.WriteLine("Not found !!");
                    break;
                }
                Console.WriteLine("Enter the new student name:");
                Console.WriteLine();
                string newName = Console.ReadLine() ?? string.Empty;
                students[index] = newName;

                Console.WriteLine("Updated List : ");
                Console.WriteLine();
                foreach (string student in students) Console.WriteLine(student);
                Console.WriteLine();

                break;
            }

        case 5:
            {
                Console.WriteLine("Enter the existing student name from below to be get deleted from record :");
                Console.WriteLine();
                foreach (string student in students) Console.WriteLine(student);
                Console.WriteLine();

                string existingName = Console.ReadLine() ?? string.Empty;
                students.Remove(existingName);

                Console.WriteLine("Updated List : ");
                Console.WriteLine();
                foreach (string student in students) Console.WriteLine(student);
                Console.WriteLine();

                break;
            }

        default:
            {
                Console.WriteLine("Unexpected Operation");
                break;
            }
    }
}
