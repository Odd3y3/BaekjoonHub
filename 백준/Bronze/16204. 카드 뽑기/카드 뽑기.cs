int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
int o1 = arr[1];
int x1 = arr[0] - arr[1];
int o2 = arr[2];
int x2 = arr[0] - arr[2];
Console.WriteLine(Math.Min(o1, o2) + Math.Min(x1, x2));