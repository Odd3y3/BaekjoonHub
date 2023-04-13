
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int s = int.Parse(input[1]);
            int start = 0;
            int sum = 0;
            int result = int.MaxValue;
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for(int end = 0; end < n; end++)
            {
                sum += arr[end];
                while(sum >= s)
                {
                    result = Math.Min(result, end - start + 1);
                    sum -= arr[start];
                    start++;
                }
            }
            if (result == int.MaxValue)
                Console.WriteLine(0);
            else
                Console.WriteLine(result);
        }
    }
}
