
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int l = input[0];
            int w = input[1];
            int h = input[2];

            int n = int.Parse(Console.ReadLine());
            int[] cubes = new int[20];
            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                cubes[input[0]] = input[1];
            }

            int result = 0;
            Console.WriteLine(Solve(l, w, h, cubes, ref result) ? result : -1);
        }

        static bool Solve(int a, int b, int c, int[] cubes, ref int result)
        {
            //0이면 패스
            if (a <= 0 || b <= 0 || c <= 0)
                return true;

            (a, b, c) = Sort(a, b, c);

            //value 는 2의 제곱수
            int temp = a;
            int i = 0;
            while(temp > 0)
            {
                i++;
                temp /= 2;
            }

            int value = 1;
            for (int j = 0; j < i - 1; j++)
                value *= 2;

            //2의 제곱수 부분
            if (!Solve2(i - 1, cubes, ref result))
                return false;

            //나머지 부분 재귀호출
            if (!Solve(value, value, a - value, cubes, ref result))
                return false;
            if (!Solve(value, value, b - value, cubes, ref result))
                return false;
            if (!Solve(value, value, c - value, cubes, ref result))
                return false;
            if (!Solve(a - value, b - value, value, cubes, ref result))
                return false;
            if (!Solve(b - value, c - value, value, cubes, ref result))
                return false;
            if (!Solve(c - value, a - value, value, cubes, ref result))
                return false;
            if (!Solve(a - value, b - value, c - value, cubes, ref result))
                return false;

            return true;
        }

        static bool Solve2(int idx, int[] cubes, ref int result)
        {
            if(idx < 0)
                return false;

            if (cubes[idx] > 0)
            {
                cubes[idx]--;
                result++;
            }
            else
            {
                for(int i = 0; i < 8; i++)
                {
                    if(!Solve2(idx - 1, cubes, ref result))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        static (int, int, int) Sort(int a, int b, int c)
        {
            for(int i = 0; i < 2; i++)
            {
                if (a > b)
                    (a, b) = (b, a);
                if (b > c)
                    (b, c) = (c, b);
            }

            return (a, b, c);
        }
    }
}