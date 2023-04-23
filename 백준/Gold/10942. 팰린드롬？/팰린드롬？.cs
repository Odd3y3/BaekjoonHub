
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool[,] isPalin = new bool[n, n];

            for(int i = 0; i < n; i++)
            {
                Func(i, i, nums, isPalin);
            }
            for(int i = 0; i < n - 1; i++)
            {
                Func(i, i + 1, nums, isPalin);
            }

            StringBuilder sb = new StringBuilder();
            int m = int.Parse(Console.ReadLine());
            for(int i = 0; i < m; i++)
            {
                int[] inputNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
                if (isPalin[inputNum[0] - 1, inputNum[1] - 1])
                    sb.AppendLine("1");
                else
                    sb.AppendLine("0");
            }
            Console.WriteLine(sb);
        }
        static void Func(int start, int end, int[] nums, bool[,] isPalin)
        {
            if (nums[start] == nums[end])
            {
                isPalin[start, end] = true;
                if(start - 1 >= 0 && end + 1 < nums.Length)
                {
                    Func(start - 1, end + 1, nums, isPalin);
                }
            }
        }
    }
}