int[] arr = new int[3];
arr[0] = int.Parse(Console.ReadLine());
arr[1] = int.Parse(Console.ReadLine());
arr[2] = int.Parse(Console.ReadLine());
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
Console.WriteLine(arr.Min() + Math.Min(a, b) - 50);