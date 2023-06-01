
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]) + 1;
            int m = int.Parse(input[1]) + 1;
            List<(int, int)> points = new List<(int, int)>();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    if (i == 0 && j == 0)
                        continue;
                    points.Add((i, j));
                }
            }

            List<ThreePoints> answers = new List<ThreePoints>();

            for(int i = 0; i < points.Count - 1; i++)
            {
                for(int j = i + 1; j < points.Count; j++)
                {
                    if (isTriangle(points[i], points[j]))
                    {
                        int a = points[i].Item1;
                        int b = points[i].Item2;
                        int c = points[j].Item1;
                        int d = points[j].Item2;
                        int[] lineLengths = { a * a + b * b, c * c + d * d, (a - c) * (a - c) + (b - d) * (b - d) };
                        Array.Sort(lineLengths);
                        answers.Add(new ThreePoints(lineLengths[0], lineLengths[1], lineLengths[2]));
                    }
                }
            }

            Console.WriteLine(answers.Distinct().Count());
        }

        static bool isTriangle((int, int) point1, (int, int) point2)
        {
            if (point1.Item1 * point2.Item2 == point1.Item2 * point2.Item1)
                return false;
            else
                return true;
        }

        struct ThreePoints
        {
            int a;
            int b;
            int c;
            public ThreePoints(int a, int b, int c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
        }
    }
}

