Console.WriteLine(": Welcome to find the occurence of aplhabets");
Console.WriteLine("Enter the text u have :");

String text = Console.ReadLine() ?? string.Empty;

Dictionary<string, int> frequency = new Dictionary<string, int>();

string[] Words = text.Split(' ');

foreach (string word in Words)
{
    if (frequency.ContainsKey(word)) frequency[word]++;
    else frequency[word] = 1;
}

Console.WriteLine("::: Word Frequency :::");

foreach (var word in frequency) Console.WriteLine(word);

