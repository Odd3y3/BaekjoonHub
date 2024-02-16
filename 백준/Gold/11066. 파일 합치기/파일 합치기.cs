
namespace TestingField
{
    internal class Program
    {
        public struct resultStruct
        {
            public int result;
            public int sum;
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int test = 0; test < t; ++test)
            {
                int k = int.Parse(Console.ReadLine());
                int[] numlist = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

                resultStruct[,] dp = new resultStruct[k,k];

                for(int i = k - 1; i >= 0; --i)
                {
                    for(int j = i; j < k; ++j)
                    {
                        if(i == j)
                        {
                            dp[i, j].result = 0;
                            dp[i, j].sum = numlist[i];
                        }
                        else
                        {
                            int min = int.MaxValue;
                            for(int n = 0; n < j - i; ++n)
                            {
                                int temp = dp[i, i + n].result + dp[i, i + n].sum + dp[i + n + 1, j].result + dp[i + n + 1, j].sum;
                                if (temp < min)
                                    min = temp;
                            }
                            dp[i, j].result = min;
                            dp[i, j].sum = dp[i, i].sum + dp[i + 1, j].sum;
                        }
                    }
                }
                Console.WriteLine(dp[0, k - 1].result);
            }
        }
    }
}