using System.Numerics;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            BigInteger n = BigInteger.Parse(input[0]);
            BigInteger m = BigInteger.Parse(input[1]);
            Console.WriteLine(n / m);
            Console.WriteLine(n % m);

        }
    }
}