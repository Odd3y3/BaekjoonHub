int n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
    Console.WriteLine(input[0] * (input[2] - 1) + input[1]);
}