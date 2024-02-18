
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dragonCurve = MakeDragonCurve();
            bool[,] map = new bool[101, 101];

            //input
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; ++i)
            {
                string[] input = Console.ReadLine().Split();
                int x = int.Parse(input[0]);
                int y = int.Parse(input[1]);
                int d = int.Parse(input[2]);
                int g = int.Parse(input[3]);

                //0 오른쪽
                //1 위쪽
                //2 왼쪽
                //3 아래쪽
                DrawDragonCurve(x, y, d, g, dragonCurve, map);
            }

            //result
            int result = 0;
            for(int i = 0; i < 100; ++i)
            {
                for(int j = 0; j < 100; ++j)
                {
                    if (map[i, j] && map[i + 1, j] && map[i, j + 1] && map[i + 1, j + 1])
                        ++result;
                }
            }
            Console.WriteLine(result);
        }

        static void DrawDragonCurve(int x, int y, int d, int g, int[] dragonCurve, bool[,] map)
        {
            map[x, y] = true;
            for(int i = 0; i < Math.Pow(2, g); ++i)
            {
                int dir = (dragonCurve[i] + d) % 4;
                switch (dir)
                {
                    case 0: //오른쪽
                        ++x;
                        break;
                    case 1: //위쪽
                        --y;
                        break;
                    case 2: //왼쪽
                        --x;
                        break;
                    case 3: //아래쪽
                        ++y;
                        break;
                    default:
                        break;
                }
                map[x, y] = true;
            }
        }

        static int[] MakeDragonCurve()
        {
            int[] dragonCurve = new int[1024];  //최대 10세대 = 2^10
            dragonCurve[0] = 0;                 //시작 방향 오른쪽

            int g = 1;
            for(int i = 1; i < 1024; ++i)
            {
                if (i == g)
                    g *= 2;

                dragonCurve[i] = (dragonCurve[g - i - 1] + 1) % 4;
            }

            return dragonCurve;
        }
    }
}