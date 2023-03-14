int n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    decimal[] arr = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
    Console.WriteLine(string.Format("${0:0.00}", arr[0] * arr[1] * arr[2]));
}