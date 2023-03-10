int n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    int length = Console.ReadLine().Length;
    Console.WriteLine(length >= 6 && length <= 9 ? "yes" : "no");
}