
using System.Numerics;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
            Console.WriteLine(input[0] * input[1]);
        }
    }
}