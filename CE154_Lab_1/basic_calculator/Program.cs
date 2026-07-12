Console.WriteLine("Welcome to the Basic Calculator!");

Console.WriteLine("which operation would you like to perform?");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
Console.WriteLine("5. Modulus");

int operation = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the first number:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the second number:");
int number2 = Convert.ToInt32(Console.ReadLine());

if ((number2 == 0) && (operation == 4 || operation == 5))
{
    Console.WriteLine("Error: MATH ERROR");
}
else
{
    switch (operation)
    {
        case 1:
            Console.WriteLine($"Result: {number1 + number2}");
            break;
        case 2:
            Console.WriteLine($"Result: {number1 - number2}");
            break;
        case 3:
            Console.WriteLine($"Result: {number1 * number2}");
            break;
        case 4:
            Console.WriteLine($"Result: {number1 / number2}");
            break;
        case 5:
            Console.WriteLine($"Result: {number1 % number2}");
            break;
        default:
            Console.WriteLine("Invalid operation selected.");
            break;
    }
}
