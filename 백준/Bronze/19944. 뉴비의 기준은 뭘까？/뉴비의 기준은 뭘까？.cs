int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
if (input[1] <= 2)
    Console.WriteLine("NEWBIE!");
else if (input[1] <= input[0])
    Console.WriteLine("OLDBIE!");
else
    Console.WriteLine("TLE!");