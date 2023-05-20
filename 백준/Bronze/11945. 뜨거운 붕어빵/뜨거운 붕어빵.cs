string[] input = Console.ReadLine().Split();
for(int i = 0; i < int.Parse(input[0]); i++)
{
    var temp = Console.ReadLine().Reverse();
    Console.WriteLine(string.Join("", temp));
}