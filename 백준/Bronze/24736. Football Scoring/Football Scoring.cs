int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int ra = 0;
int rb = 0;
for(int i = 0; i < 5; i++)
{
    ra = a[0] * 6 + a[1] * 3 + a[2] * 2 + a[3] + a[4] * 2;
    rb = b[0] * 6 + b[1] * 3 + b[2] * 2 + b[3] + b[4] * 2;
}
Console.WriteLine(ra + " " + rb);