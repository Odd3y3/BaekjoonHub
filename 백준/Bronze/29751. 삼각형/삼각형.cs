int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine(((float)input[0] * input[1] / 2).ToString("0.0"));