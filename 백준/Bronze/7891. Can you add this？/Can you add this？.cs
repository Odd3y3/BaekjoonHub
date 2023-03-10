int t = int.Parse(Console.ReadLine());
for(int i = 0; i < t; i++)
    Console.WriteLine(Console.ReadLine().Split(' ').Select(x => int.Parse(x)).Sum());