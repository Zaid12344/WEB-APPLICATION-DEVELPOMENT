using System.Runtime;
List<string> history = new List<string>();
while (true)
{
    Console.WriteLine(":: Welcome to History Manager ::");
    Console.WriteLine(":: Please select an operation ::");

    Console.WriteLine("1. Visit a new web-page");
    Console.WriteLine("2. Go Back (pop the latest page)");
    Console.WriteLine("3. View current page");
    Console.WriteLine("4. Display browsing history");
    int operation = Convert.ToInt32(Console.ReadLine());

    if (operation == 0) { Console.WriteLine("Exit history page"); break;}
    switch (operation)
    {
        case 1:
            {
                Console.WriteLine("Enter the URL of the new web-page:");
                string url = Console.ReadLine() ?? String.Empty;
                history.Add(url);
                Console.WriteLine($"Visited: {url}");
                Console.WriteLine();
                break;
            }

        case 2:
            {
                if (history.Count > 0)
                {
                    string lastVisited = history[history.Count - 1];
                    history.RemoveAt(history.Count - 1);
                    Console.WriteLine($"Went back from: {lastVisited}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No pages to go back to.");
                    Console.WriteLine();
                }
                break;
            }

        case 3:
            {
                if (history.Count > 0)
                {
                    string currentPage = history[history.Count - 1];
                    Console.WriteLine($"Current page: {currentPage}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No pages visited yet.");
                    Console.WriteLine();
                }
                break;
            }

        case 4:
            {
                if (history.Count > 0)
                {
                    Console.WriteLine("Browsing history:");
                    foreach (string page in history)
                    {
                        Console.WriteLine(page);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("No browsing history available.");
                    Console.WriteLine();
                }
                break;
            }

        default:
            {
                Console.WriteLine("Invalid operation");
                Console.WriteLine();
                break;
            }

    }
}