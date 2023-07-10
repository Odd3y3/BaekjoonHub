
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> dp = new List<int>();
            int[] indexArr = new int[n];
            for(int i = 0; i < n; ++i)
            {
                indexArr[i] = Solve(arr[i], dp);
            }

            int max = -1;
            int index = max;
            Stack<int> stack = new Stack<int>();
            for(int i = n - 1; i >= 0; --i)
            {
                if(indexArr[i] > max)
                {
                    max = indexArr[i];
                    stack.Clear();
                    stack.Push(arr[i]);
                    index = max - 1;
                }
                else if (indexArr[i] == index)
                {
                    index--;
                    stack.Push(arr[i]);
                }
            }

            //output
            StringBuilder sb = new StringBuilder();
            Console.WriteLine(max + 1);
            foreach (var item in stack)
            {
                sb.Append(item);
                sb.Append(" ");
            }
            Console.WriteLine(sb);
        }

        static int Solve(int n, List<int> dp)
        {
            if (dp.Count == 0 || dp[dp.Count - 1] < n)
            {
                dp.Add(n);
                return dp.Count - 1;
            }
            else
            {
                //이분 탐색
                return Recursive(0, dp.Count - 1, n, dp);

            }
            
        }

        static int Recursive(int start, int end, int value, List<int> dp)
        {
            if(start == end)
            {
                if(dp[start] < value)
                {
                    //index = start + 1
                    dp[start + 1] = value;
                    return start + 1;
                }
                else
                {
                    //index = start
                    dp[start] = value;
                    return start;
                }
            }
            else if(start + 1 == end)
            {
                if (dp[start] >= value)
                {
                    dp[start] = value;
                    return start;
                }
                else if (dp[start] < value && dp[end] >= value)
                {
                    dp[end] = value;
                    return end;
                }
                else
                {
                    dp[end + 1] = value;
                    return end + 1;
                }
            }
            else
            {
                int middleIndex = (start + end) / 2;
                if (dp[middleIndex] >= value)
                {
                    return Recursive(start, middleIndex - 1, value, dp);
                }
                else
                {
                    return Recursive(middleIndex + 1, end, value, dp);
                }
            }
        }

    }
}