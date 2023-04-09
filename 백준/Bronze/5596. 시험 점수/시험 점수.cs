int a = Console.ReadLine().Split().Select(int.Parse).Sum();
int b = Console.ReadLine().Split().Select(int.Parse).Sum();
Console.WriteLine(Math.Max(a,b));