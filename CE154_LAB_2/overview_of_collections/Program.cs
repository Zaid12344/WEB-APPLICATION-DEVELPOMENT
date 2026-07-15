Console.WriteLine("This is list ::");
Console.WriteLine();

List<int> numbers = [45, 556, 87, 100, 90];

foreach (var n in numbers) { Console.WriteLine(n); }

Console.WriteLine("This is Dictionary ::");
Console.WriteLine();

Dictionary<int, char> alphabets = new Dictionary<int, char>();
alphabets.Add(97, 'a');
alphabets.Add(98, 'b');
alphabets.Add(99, 'c');
alphabets.Add(100, 'd');
alphabets.Add(101, 'e');

foreach (var n in alphabets) { Console.WriteLine(n); }

Console.WriteLine("This is Stack ::");
Console.WriteLine();

Stack<string> subjects = new Stack<string>();
subjects.Push("AA");
subjects.Push("OS");
subjects.Push("WAD");
subjects.Push("MFP");
subjects.Push("WAD");

foreach (var sub in subjects) { Console.WriteLine(sub); }

Console.WriteLine("This is Queue ::");
Console.WriteLine();

Queue<int> process = new Queue<int>();
process.Enqueue(3927);
process.Enqueue(8104);
process.Enqueue(5461);
process.Enqueue(2098);
process.Enqueue(6735);

foreach (var id in process) { Console.WriteLine(id); }
