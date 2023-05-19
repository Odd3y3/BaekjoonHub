
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            long[] p = new long[101];
            Init(p);
            for(int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(p[n]);
            }
        }
        static void Init(long[] p)
        {
            p[1] = 1;
            p[2] = 1;
            p[3] = 1;
            p[4] = 2;
            p[5] = 2;
            for(int i = 6; i <= 100; i++)
            {
                p[i] = p[i - 1] + p[i - 5];
            }
        }
    }
}

