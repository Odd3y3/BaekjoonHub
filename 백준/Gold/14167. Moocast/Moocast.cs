
namespace TestField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for(int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                Point point = new Point(input[0], input[1]);
                points[i] = point;
            }

            bool[] visit = new bool[n];
            PriorityQueue<(int, int), int> pq = new PriorityQueue<(int, int), int>();
            pq.Enqueue((0, 0), 0);
            int result = 0;
            while(pq.Count > 0)
            {
                int pointIndex, dist;
                (pointIndex, dist) = pq.Dequeue();

                if (!visit[pointIndex])
                {
                    if (dist > result)
                        result = dist;

                    visit[pointIndex] = true;
                    for(int i = 0; i < n; i++)
                    {
                        if (!visit[i])
                        {
                            int tempDist = CalDistance(points[pointIndex], points[i]);
                            pq.Enqueue((i, tempDist), tempDist);
                        }
                    }
                }
            }
            Console.WriteLine(result);
        }

        static int CalDistance(Point point1, Point point2)
        {
            int x = point1.x - point2.x;
            int y = point1.y - point2.y;
            return x * x + y * y;
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
        }
    }
}