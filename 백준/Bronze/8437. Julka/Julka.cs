
using System.Numerics;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine((a + b) / 2);
            Console.WriteLine((a - b) / 2);
        }
    }
}