int n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
    if (arr[0] * arr[1] > arr[2] * arr[3])
        Console.WriteLine("TelecomParisTech");
    else if (arr[0] * arr[1] < arr[2] * arr[3])
        Console.WriteLine("Eurecom");
    else
        Console.WriteLine("Tie");
}