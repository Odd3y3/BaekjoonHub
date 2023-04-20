
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int test = 0; test < t; test++)
            {
                string[] input = Console.ReadLine().Split();
                int x1 = int.Parse(input[0]);
                int y1 = int.Parse(input[1]);
                int x2 = int.Parse(input[2]);
                int y2 = int.Parse(input[3]);
                int n = int.Parse(Console.ReadLine());
                int result = 0;
                for(int i = 0; i < n; i++)
                {
                    input = Console.ReadLine().Split();
                    int cx = int.Parse(input[0]);
                    int cy = int.Parse(input[1]);
                    int r = int.Parse(input[2]);
                    if (isInCircle(x1, y1, cx, cy, r) ^ isInCircle(x2, y2, cx, cy, r))
                        result++;
                }
                Console.WriteLine(result);
            }
        }
        static bool isInCircle(int x, int y, int cx, int cy, int r)
        {
            if ((x - cx) * (x - cx) + (y - cy) * (y - cy) < r * r)
                return true;
            else
                return false;
        }
    }
}