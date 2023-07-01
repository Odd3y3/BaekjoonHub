int n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    for (int x = 0; x < i; x++)
        Console.Write(' ');
    for (int x = n - i; x > 0; x--)
        Console.Write('*');
    Console.WriteLine();
}