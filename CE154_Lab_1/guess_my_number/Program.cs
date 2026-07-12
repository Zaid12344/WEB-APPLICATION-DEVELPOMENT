
int random = Random().Next(1, 101);

Console.WriteLine("Guess Number between 1 & 100");
int counter = 0;
do
{
    Console.Write("Enter your guess: ");
    int guess = Convert.ToInt32(Console.ReadLine());
    if (guess < random)
    {
        Console.WriteLine("Too low! Try again.");
        counter++;
    }
    else if (guess > random)
    {
        Console.WriteLine("Too high! Try again.");
        counter++;
    }
    else
    {
        Console.WriteLine("Congratulations! You guessed the number.");
        Console.WriteLine($"It took you {counter} attempts.");
        break;
    }
} while (true);

