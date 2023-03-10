int[] a = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
int[] c = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
Console.Write(c[0] - a[2]);
Console.Write(" ");
Console.Write(c[1] / a[1]);
Console.Write(" ");
Console.Write(c[2] - a[0]);
Console.WriteLine();