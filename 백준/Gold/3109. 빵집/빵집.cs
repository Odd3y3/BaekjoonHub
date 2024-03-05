
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int r = int.Parse(input[0]);
            int c = int.Parse(input[1]);
            bool[,] map = new bool[r, c];
            for(int i = 0; i < r; i++)
            {
                char[] chars = Console.ReadLine().ToCharArray();
                for(int j = 0; j < c; j++)
                {
                    if (chars[j] == '.')
                        map[i, j] = true;
                    else
                        map[i, j] = false;
                }
            }

            //process
            int result = 0;
            for(int i = 0; i < r; i++)
            {
                if (DFS(i, 0, map))
                    result++;
            }
            Console.WriteLine(result);
        }
        static bool DFS(int x, int y, bool[,] map)
        {
            if (!map[x, y]) return false;

            bool result = false;

            if (y == map.GetLength(1) - 1)  result = true;

            else if (x > 0 && DFS(x - 1, y + 1, map)) result = true;
            else if (DFS(x, y + 1, map)) result = true;
            else if (x < map.GetLength(0) - 1 && DFS(x + 1, y + 1, map)) result = true;

            
            map[x, y] = false;
            

            return result;
        }
    }
}