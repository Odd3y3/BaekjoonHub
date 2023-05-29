int[] arr = { 1, 2, 3, 4, 5, 4, 3, 2 };
int n = int.Parse(Console.ReadLine());
Console.WriteLine(arr[(n - 1) % 8]);