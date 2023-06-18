int n = int.Parse(Console.ReadLine());
int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine(Math.Min(n, arr[0]) + Math.Min(n, arr[1]) + Math.Min(n, arr[2]));