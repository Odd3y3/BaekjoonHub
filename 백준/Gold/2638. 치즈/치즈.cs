
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[,] map = new int[n, m];
            for(int i = 0; i < n; ++i)
            {
                int[] temp = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for(int j = 0; j < m; ++j)
                {
                    map[i, j] = temp[j];
                }
            }

            //바깥 공기를 0 -> 2로 변경 ( 깊이 우선탐색 or 너비 우선탐색 )
            RecursiveFunc(0, 0, map, n, m);

            //모든 칸 돌면서
            //치즈 녹이고, 녹인 치즈 주변에 0 있으면 2로 변경,
            //녹인 치즈가 없으면 end
            int result = 0;
            int[,] nextMap = new int[n, m];
            List<(int, int)> nextCheese = new List<(int, int)>();
            while (true)
            {
                nextCheese.Clear();
                for(int i = 0; i < n; ++i)
                {
                    for(int j = 0; j < m; ++j)
                    {
                        if (map[i, j] == 1)
                        {
                            int airCount = 0;
                            if (map[i - 1, j] == 2)
                                ++airCount;
                            if (map[i + 1, j] == 2)
                                ++airCount;
                            if (map[i, j - 1] == 2)
                                ++airCount;
                            if (map[i, j + 1] == 2)
                                ++airCount;

                            if(airCount >= 2)
                            {
                                //치즈 녹일 부분 저장
                                nextCheese.Add((i, j));
                            }
                        }
                    }
                }

                if (nextCheese.Count == 0)
                    break;

                foreach (var item in nextCheese)
                {
                    map[item.Item1, item.Item2] = 0;
                }
                foreach (var item in nextCheese)
                {
                    RecursiveFunc(item.Item1, item.Item2, map, n, m);
                }

                ++result;
            }

            Console.WriteLine(result);
        }

        static void RecursiveFunc(int x, int y, int[,] map, int n, int m)
        {
            if (map[x, y] != 0)
                return;

            map[x, y] = 2;

            if (x > 0)
                RecursiveFunc(x - 1, y, map, n, m);
            if (y > 0)
                RecursiveFunc(x, y - 1, map, n, m);
            if (x < n - 1)
                RecursiveFunc(x + 1, y, map, n, m);
            if (y < m - 1)
                RecursiveFunc(x, y + 1, map, n, m);
        }
    }
}