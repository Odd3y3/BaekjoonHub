
namespace TestingField
{
    internal class Program
    {
        struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int test = 0; test < t; test++)
            {
                int n = int.Parse(Console.ReadLine());

                Point[] points = new Point[n];

                string[] input;
                for(int i = 0; i < n; i++)
                {
                    input = Console.ReadLine().Split();
                    points[i] = new Point(int.Parse(input[0]), int.Parse(input[1]));
                }

                Console.WriteLine(Solve(n, points));
            }
        }

        static double Solve(int n, Point[] points)
        {
            double result = double.MaxValue;
            Func(0, n / 2, 0, 0, points, ref result);

            return result;
        }

        static void Func(int idx, int n, int x, int y, Point[] points, ref double result)
        {
            if(idx == points.Length)        
            {
                double value = Math.Sqrt((long)x * x + (long)y * y);
                if (result > value)
                    result = value;
                return;
            }

            if(n > 0)
            {
                Func(idx + 1, n - 1, x + points[idx].x, y + points[idx].y, points, ref result);
            }

            if(points.Length - idx > n) 
            {
                Func(idx + 1, n, x - points[idx].x, y - points[idx].y, points, ref result);
            }
        }
    }
}