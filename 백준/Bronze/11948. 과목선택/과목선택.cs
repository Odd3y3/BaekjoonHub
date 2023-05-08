int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int d = int.Parse(Console.ReadLine());
int e = int.Parse(Console.ReadLine());
int f = int.Parse(Console.ReadLine());
int[] ints = { a, b, c, d };
Console.WriteLine(ints.Sum() - ints.Min() + MathF.Max(e, f));