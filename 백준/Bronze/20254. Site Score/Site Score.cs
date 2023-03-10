int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
Console.WriteLine(56 * input[0] + 24 * input[1] + 14 * input[2] + 6 * input[3]);