
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).OrderBy(x => x).ToArray();
            int[] sum = new int[n];
            sum[0] = input[0];
            for(int i = 1; i < n; i++)
                sum[i] = sum[i - 1] + input[i];
            Console.WriteLine(sum.Sum());
        }
    }
}