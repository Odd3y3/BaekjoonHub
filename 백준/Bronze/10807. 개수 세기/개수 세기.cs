Console.ReadLine();
var arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x));
int v = int.Parse(Console.ReadLine());
Console.WriteLine(arr.Count(x => x == v));