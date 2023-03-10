int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
Console.WriteLine((input[2] / input[1]) + " " + (input[2] % input[1]));