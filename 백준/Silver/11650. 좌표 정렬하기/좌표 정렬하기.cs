
using System.Text;

namespace TestingField
{
    internal class Program
    {
        struct point
        {
            public int x;
            public int y;
            public point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<point> points = new List<point>();
            for(int i = 0; i < n; i++)
            {
                int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();
                point a = new point(ints[0], ints[1]);
                points.Add(a);
            }
            var answer = points.OrderBy(point => point.y).OrderBy(point => point.x).ToArray();

            //output
            StringBuilder sb = new StringBuilder();
            foreach(point point in answer)
            {
                sb.Append(point.x);
                sb.Append(' ');
                sb.AppendLine(point.y.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}