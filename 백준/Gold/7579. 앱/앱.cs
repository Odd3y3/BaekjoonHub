
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[] bytes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] costs = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] prevArr = new int[10001];
            int[] currArr = new int[10001];
            for(int i = 0; i < n; i++)
            {
                for(int j = costs[i]; j <= 10000; j++)
                {
                    currArr[j] = Math.Max(prevArr[j - costs[i]] + bytes[i], prevArr[j]);
                }
                prevArr = currArr.ToArray();
            }
            for(int i = 0; i <= 10000; i++)
            {
                if (prevArr[i] >= m)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
    }
}