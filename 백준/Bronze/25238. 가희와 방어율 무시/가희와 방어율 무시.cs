int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
Console.WriteLine(input[0] * (100 - input[1])/(float)100 >= 100 ? 0 : 1);