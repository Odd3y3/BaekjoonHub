
namespace TestingField
{
    internal class Program
    {
        static bool IsSame(int x, int y, int size, int[,] map)
        {
            int firstNum = map[x, y];
            for(int i = x; i < x + size; i++)
            {
                for(int j = y; j < y + size; j++)
                {
                    if (map[i, j] != firstNum)
                        return false;
                }
            }
            return true;
        }
        static void Func(int x, int y, int size, int[,] map, ref int white, ref int blue)
        {
            if (IsSame(x, y, size, map))
            {
                if (map[x, y] == 0)
                    white++;
                else
                    blue++;
                return ;
            }
            else
            {
                Func(x, y, size / 2, map, ref white, ref blue);
                Func(x + size / 2, y, size / 2, map, ref white, ref blue);
                Func(x, y + size / 2, size / 2, map, ref white, ref blue);
                Func(x + size / 2, y + size / 2, size / 2, map, ref white, ref blue);
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] map = new int[n, n];
            for(int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                for(int j = 0; j < n; j++)
                {
                    map[i, j] = input[j];
                }
            }
            int white = 0;
            int blue = 0;
            Func(0, 0, n, map, ref white, ref blue);
            Console.WriteLine(white);
            Console.WriteLine(blue);
        }
    }
}