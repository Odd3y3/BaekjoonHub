int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine(3 * arr[2] * arr[1] / arr[0]);