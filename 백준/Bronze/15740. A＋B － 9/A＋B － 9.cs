
using System.Numerics;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] arr = Console.ReadLine().Split(' ').Select(x => BigInteger.Parse(x)).ToArray();
            Console.WriteLine(arr[0] + arr[1]);
        }
    }
}