string[] input = Console.ReadLine().Split();
int a = int.Parse(input[0]);
int b = int.Parse(input[1]);
input = Console.ReadLine().Split();
int c = int.Parse(input[0]);
int d = int.Parse(input[1]);
Console.WriteLine(Math.Min(a + d, b + c));