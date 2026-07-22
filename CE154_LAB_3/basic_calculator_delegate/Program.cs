class Program
{
    delegate int Calculate(int n1, int n2);
    static int Addition(int n1, int n2) { return n1 + n2; }
    static int Multiply(int n1, int n2) { return n1 * n2; }
    static int Subtraction(int n1, int n2) { return n1 - n2; }
    static int Division(int n1, int n2) { return n1 / n2; }
    static void Main(string[] args)
    {
        Calculate cl;

        Console.WriteLine("Welcome to the Basic Calculator made with Delegate !");

        Console.WriteLine("which operation would you like to perform?");
        Console.WriteLine("1. Addition");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");

        int operation = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the first number:");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int number2 = Convert.ToInt32(Console.ReadLine());
        if ((number2 == 0) && (operation == 4))
        {
            Console.WriteLine("Error: MATH ERROR");
        }
        else
        {
            switch (operation)
            {
                case 1:
                    cl = Addition;
                    Console.WriteLine("Result: " + cl(number1, number2));
                    break;
                case 2:
                    cl = Subtraction;
                    Console.WriteLine("Result: " + cl(number1, number2));
                    break;
                case 3:
                    cl = Multiply;
                    Console.WriteLine("Result: " + cl(number1, number2));
                    break;
                case 4:
                    cl = Division;
                    Console.WriteLine("Result: " + cl(number1, number2));
                    break;
                default:
                    Console.WriteLine("Invalid operation selected.");
                    break;
            }
        }
    }
}

