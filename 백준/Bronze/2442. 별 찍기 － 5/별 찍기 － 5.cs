int n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    for (int x = n - i - 1; x > 0; x--)
        Console.Write(' ');
    for (int x = 0; x <= i * 2; x++)
        Console.Write('*');
    Console.WriteLine();
}