int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
if (input[0] > input[2])
    Console.WriteLine("Bus");
else if (input[1] == input[2])
    Console.WriteLine("Anything");
else if (input[1] > input[2])
    Console.WriteLine("Subway");
else
    Console.WriteLine("Bus");