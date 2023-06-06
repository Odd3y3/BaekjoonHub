
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[,] map = new int[n, m];

            //input
            for(int i = 0; i < n; i++)
            {
                int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int j = 0; j < m; j++)
                    map[i, j] = temp[j];
            }

            //zero list 구하기
            List<(int, int)> zeroList = new List<(int, int)>();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (map[i, j] == 0)
                        zeroList.Add((i, j));
                }
            }

            //progress
            int max = 0;
            for(int i = 0; i < zeroList.Count - 2; i++)
            {
                for(int j = i + 1; j < zeroList.Count - 1; j++)
                {
                    for(int k = j + 1; k < zeroList.Count; k++)
                    {
                        int[,] newMap = CopyArr(map);
                        newMap[zeroList[i].Item1, zeroList[i].Item2] = 1;
                        newMap[zeroList[j].Item1, zeroList[j].Item2] = 1;
                        newMap[zeroList[k].Item1, zeroList[k].Item2] = 1;
                        Solve(newMap);
                        max = Math.Max(max, CountZero(newMap));
                    }
                }
            }
            Console.WriteLine(max);
        }

        static void Solve(int[,] map)
        {
            int n = map.GetLength(0);
            int m = map.GetLength(1);
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (map[i, j] == 2)
                        SpreadVirus(map, i, j);
                }
            }
        }

        static void SpreadVirus(int[,] map, int x, int y)
        {
            int n = map.GetLength(0);
            int m = map.GetLength(1);
            if (map[x, y] == 0 || map[x, y] == 2)
            {
                map[x, y] = 3;
                if (x > 0)
                    SpreadVirus(map, x - 1, y);
                if (y > 0)
                    SpreadVirus(map, x, y - 1);
                if (x < n - 1)
                    SpreadVirus(map, x + 1, y);
                if (y < m - 1)
                    SpreadVirus(map, x, y + 1);
            }
            else
                return;
        }

        static int CountZero(int[,] map)
        {
            int n = map.GetLength(0);
            int m = map.GetLength(1);
            int sum = 0;
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (map[i, j] == 0)
                        sum++;
                }
            }
            return sum;
        }

        static int[,] CopyArr(int[,] map)
        {
            int n = map.GetLength(0);
            int m = map.GetLength(1);
            int[,] newMap = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    newMap[i, j] = map[i, j];
                }
            }
            return newMap;
        }
    }
}

