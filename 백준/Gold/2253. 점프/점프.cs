
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            List<int> smallStones = new List<int>();
            for(int i = 0; i < m; i++)
            {
                smallStones.Add(int.Parse(Console.ReadLine()));
            }
            smallStones.Sort();

            int smallStonesIndex = 0;
            int[,] dp = new int[n + 1, 250];
            dp[2, 1] = 1;
            for(int i = 2; i <= n; i++)
            {
                if (smallStonesIndex < smallStones.Count && smallStones[smallStonesIndex] == i)
                {
                    smallStonesIndex++;
                }
                else
                {
                    for (int j = 1; j < 250; j++)
                    {
                        if (dp[i, j] != 0)
                        {
                            if (j != 1 && i + j - 1 <= n)
                                dp[i + j - 1, j - 1] = (dp[i + j - 1, j - 1] == 0) ? dp[i, j] + 1 : Math.Min(dp[i + j - 1, j - 1], dp[i, j] + 1);

                            if(i + j <= n)
                                dp[i + j, j] = (dp[i + j, j] == 0) ? dp[i, j] + 1 : Math.Min(dp[i + j, j], dp[i, j] + 1);

                            if(i + j + 1 <= n)
                                dp[i + j + 1, j + 1] = (dp[i + j + 1, j + 1] == 0) ? dp[i, j] + 1 : Math.Min(dp[i + j + 1, j + 1], dp[i, j] + 1);
                        }
                    }
                }
            }

            int min = -1;
            for(int i = 0; i < 250; i++)
            {
                if (dp[n, i] != 0)
                    min = min == -1 ? dp[n, i] : Math.Min(dp[n, i], min);
            }
            Console.WriteLine(min);
        }
    }
}

