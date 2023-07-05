
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] map = new char[n, n]; 
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for(int j = 0; j < n; j++)
                {
                    map[i, j] = input[j];
                }
            }

            //progress1
            bool[,] visit = new bool[n, n];
            int answer = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    answer += Solve(i, j, map[i, j], n, map, visit);
                }
            }

            Console.Write(answer + " ");

            //R -> G
            RtoG(n, map);

            //progress2
            visit = new bool[n, n];
            answer = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    answer += Solve(i, j, map[i, j], n, map, visit);
                }
            }

            Console.WriteLine(answer);
        }

        static int Solve(int x, int y, char c, int n, char[,] map, bool[,] visit)
        {
            if (visit[x, y] || map[x,y] != c)
                return 0;
            visit[x, y] = true;

            if (x > 0)
                Solve(x - 1, y, c, n, map, visit);
            if (y > 0)
                Solve(x, y - 1, c, n, map, visit);
            if (x < n - 1)
                Solve(x + 1, y, c, n, map, visit);
            if (y < n - 1)
                Solve(x, y + 1, c, n, map, visit);

            return 1;
        }

        static void RtoG(int n, char[,] map)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (map[i, j] == 'R')
                    {
                        map[i, j] = 'G';
                    }
                }
            }
        }
    }
}