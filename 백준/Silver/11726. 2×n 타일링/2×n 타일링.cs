
using System.Numerics;

namespace TestingField
{
    internal class Program
    {
        static BigInteger Factorial(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        static BigInteger nCr(int n, int r)
        {
            return Factorial(n) / (Factorial(n - r) * Factorial(r));
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger sum = 0;
            for (int i = 0; i <= n / 2; i++)
            {
                sum += nCr(n - i, i);
            }
            Console.WriteLine(BigInteger.Remainder(sum, 10007));
        }
    }
}