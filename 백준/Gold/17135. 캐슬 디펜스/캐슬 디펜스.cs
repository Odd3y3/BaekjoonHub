
using System.Runtime.Intrinsics.X86;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Input
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int d = int.Parse(input[2]);
            bool[,] map = new bool[n, m];
            for(int i = 0; i < n; ++i)
            {
                input = Console.ReadLine().Split();
                for(int j = 0; j < m; ++j)
                {
                    if (input[j] == "1")
                        map[i, j] = true;
                }
            }

            //progress
            //궁수가 i, k, j에 있을 때 ( y 는 n)
            int max = 0;
            for(int i = 0; i < m - 2; ++i)
            {
                for(int j = i + 1; j < m - 1; ++j)
                {
                    for(int k = j + 1; k < m; ++k)
                    {
                        bool[,] newMap = new bool[n, m];
                        for (int x = 0; x < n; ++x)
                            for (int y = 0; y < m; ++y)
                                newMap[x, y] = map[x, y];
                        max = Math.Max(max, Solve(i, j, k, n, m, newMap, d));
                    }
                }
            }

            Console.WriteLine(max);
        }

        static int Solve(int i, int j, int k, int n, int m, bool[,] map, int dist)
        {
            Point arc1 = new Point(n, i);
            Point arc2 = new Point(n, j);
            Point arc3 = new Point(n, k);

            int result = 0;

            for(int index = 0; index < n; ++index)
            {
                int dist1 = int.MaxValue;
                int dist2 = int.MaxValue;
                int dist3 = int.MaxValue;
                Point result1 = new Point(n, m);
                Point result2 = new Point(n, m);
                Point result3 = new Point(n, m);


                for(int x = 0; x < n; ++x)
                {
                    for(int y = 0; y < m; ++y)
                    {
                        if (!map[x, y])
                            continue;

                        Point point = new Point(x, y);
                        //1
                        int tempDist = point.GetDistance(arc1);
                        if(dist1 >= tempDist && tempDist <= dist)
                        {
                            if (dist1 != tempDist || point.y < result1.y)
                                result1 = point;
                            dist1 = tempDist;
                        }
                        //1
                        tempDist = point.GetDistance(arc2);
                        if (dist2 >= tempDist && tempDist <= dist)
                        {
                            if (dist2 != tempDist || point.y < result2.y)
                                result2 = point;
                            dist2 = tempDist;
                        }
                        //1
                        tempDist = point.GetDistance(arc3);
                        if (dist3 >= tempDist && tempDist <= dist)
                        {
                            if (dist3 != tempDist || point.y < result3.y)
                                result3 = point;
                            dist3 = tempDist;
                        }
                    }
                }
                if(dist1 != int.MaxValue)
                {
                    map[result1.x, result1.y] = false;
                    result++;

                }
                if (dist2 != int.MaxValue && map[result2.x, result2.y] == true)
                {
                    map[result2.x, result2.y] = false;
                    result++;
                }
                if (dist3 != int.MaxValue && map[result3.x, result3.y] == true)
                {
                    map[result3.x, result3.y] = false;
                    result++;
                }

                MapDown(index, n, m, map);
            }


            return result;
        }

        static void MapDown(int index, int n, int m, bool[,] map)
        {
            for (int i = n - 2; i >= index; --i)
            {
                for(int j = 0; j < m; ++j)
                {
                    map[i + 1, j] = map[i, j];
                }
            }

            for(int i = 0; i < m; ++i)
            {
                map[index, i] = false;
            }
        }
    }

    struct Point
    {
        public int x;
        public int y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetDistance(Point point)
        {
            return Math.Abs(x - point.x) + Math.Abs(y - point.y);
        }
    }
}