
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < i; j++)
                    Console.Write(' ');
                for (int j = 0; j < 2 * (n - i) - 1; j++)
                    Console.Write('*');
                Console.WriteLine();
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 2; j++)
                    Console.Write(' ');
                for (int j = 0; j < i * 2 + 3; j++)
                    Console.Write('*');
                Console.WriteLine();
            }
        }
    }
}