int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
Console.WriteLine((arr[0] - 9) * 60 + arr[1]);