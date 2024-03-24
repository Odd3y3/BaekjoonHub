
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] edges = new int[n, n];
            int[] input;
            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for (int j = 0; j < n; j++)
                    edges[i, j] = input[j];
            }


            int[,] dp = new int[n, (int)Math.Pow(2, n)];

            int result = int.MaxValue;
            for(int i = 1; i < n; i++)
            {
                if (edges[0, i] == 0)
                    continue;
                
                int value = Solve(i, 0, dp, edges);
                if (value < 0)
                    continue;
                value += edges[0, i];

                if (value < result)
                    result = value;
            }

            Console.WriteLine(result);
        }

        static int Solve(int num, int mask, int[,] dp, int[,] edges)
        {

            int len = dp.GetLength(0);

            mask += (int)Math.Pow(2, num - 1);

            //dp에 있으면 그대로 return
            if (dp[num, mask] != 0)
                return dp[num, mask];

            //마지막 노드면 0번으로 돌아가기
            if(mask == (int)Math.Pow(2, len - 1) - 1)
            {
                if (edges[num, 0] == 0)
                {
                    dp[num, mask] = -1;
                    return -1;
                }
                else
                {
                    dp[num, mask] = edges[num, 0];
                    return edges[num, 0];
                }
            }

            int result = int.MaxValue;
            int temp = mask;
            for(int i = 1; i < len; i++)
            {
                if(temp % 2 == 0)
                {
                    int value = Solve(i, mask, dp, edges);
                    if (value == -1)
                    {
                        temp /= 2;
                        continue;
                    }
                    if (edges[num, i] == 0)
                    {
                        temp /= 2;
                        continue;
                    }
                    value += edges[num, i];
                    if (result > value)
                        result = value;
                }

                temp /= 2;
            }

            if (result == int.MaxValue)
                result = -1;
            dp[num, mask] = result;
            return dp[num, mask];
        }
    }
}