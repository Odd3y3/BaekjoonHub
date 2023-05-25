int[] input = Console.ReadLine().Split('/').Select(int.Parse).ToArray();
if (input[0] + input[2] < input[1] || input[1] == 0)
    Console.WriteLine("hasu");
else
    Console.WriteLine("gosu");