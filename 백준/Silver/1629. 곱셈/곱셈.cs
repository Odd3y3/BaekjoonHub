
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);
            int c = int.Parse(input[2]);

            long temp = mod(a, c);
            long result = 1; 
            while(b > 0)
            {
                if (b % 2 == 1)
                {
                    result = mod(result * temp, c);
                }
                b /= 2;
                temp = mod(temp * temp, c);
            }
            Console.WriteLine(result);
        }
        static int mod(long n, int mod)
        {
            return (int)(n % mod);
        }
    }
}