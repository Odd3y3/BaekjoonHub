
using System.Numerics;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            m = Math.Min(m, n - m);
            BigInteger result = 1;
            for(int i = 0; i < m; i++)
            {
                result *= (n - i);
                result /= (i + 1);
            }
            Console.WriteLine(result);
        }
    }
}