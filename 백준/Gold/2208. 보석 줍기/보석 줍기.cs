
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[] arr = new int[n];
            int[] sum = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                if (i == 0)
                    sum[i] = arr[i];
                else
                    sum[i] = sum[i - 1] + arr[i];
            }
            
            int result = sum[m - 1];
            int minValue = 0;
            for(int i = m; i < n; i++)
            {
                minValue = Math.Min(minValue, sum[i - m]);
                result = Math.Max(result, sum[i] - minValue);
            }
            Console.WriteLine(result > 0 ? result : 0);
        }
    }
}