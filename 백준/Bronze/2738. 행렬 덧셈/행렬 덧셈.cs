
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] a = new int[n, m];
            int[,] b = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                for(int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(input[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++)
                {
                    b[i, j] = int.Parse(input[j]);
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[i, j] + b[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}