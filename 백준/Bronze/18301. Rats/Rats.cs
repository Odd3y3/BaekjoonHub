int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
Console.WriteLine((int)((input[0] + 1) * (input[1] + 1) / (float)(input[2] + 1) - 1));