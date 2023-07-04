
using System.Numerics;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            BigInteger p = BigInteger.Parse(input[0]);
            int k = int.Parse(input[1]);
            bool isGood = true;
            int minPrime = 0;
            for(int i = 2; i < k; i++)
            {
                if(BigInteger.Remainder(p, i) == 0)
                {
                    isGood = false;
                    minPrime = i;
                    break;
                }
            }
            if (isGood)
                Console.WriteLine("GOOD");
            else
                Console.WriteLine($"BAD {minPrime}");
        }
    }
}