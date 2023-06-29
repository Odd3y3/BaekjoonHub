
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] s1 = Console.ReadLine().ToCharArray();
            char[] s2 = Console.ReadLine().ToCharArray();
            char[] s3 = Console.ReadLine().ToCharArray();
            int[,,] dp = new int[s1.Length + 1, s2.Length + 1, s3.Length + 1];
            for(int i = 0; i < s1.Length; ++i)
            {
                for(int j = 0; j < s2.Length; ++j)
                {
                    for(int k = 0; k < s3.Length; ++k)
                    {
                        dp[i + 1, j + 1, k + 1] = Math.Max(Math.Max(dp[i + 1, j + 1, k], dp[i + 1, j, k + 1]), dp[i, j+ 1, k+1]);
                        if (s1[i] == s2[j] && s2[j] == s3[k])
                            dp[i + 1, j + 1, k + 1] = Math.Max(dp[i + 1, j + 1, k + 1], dp[i, j, k] + 1);
                    }
                }
            }
            Console.WriteLine(dp[s1.Length, s2.Length, s3.Length]);
        }
    }
}