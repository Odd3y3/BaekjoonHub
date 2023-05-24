int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
if (input.Sum() >= 100)
    Console.WriteLine("OK");
else if (input[0] < input[1] && input[0] < input[2])
    Console.WriteLine("Soongsil");
else if (input[1] < input[0] && input[1] < input[2])
    Console.WriteLine("Korea");
else if (input[2] < input[0] && input[2] < input[1])
    Console.WriteLine("Hanyang");