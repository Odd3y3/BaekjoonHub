
namespace TestingField
{
    internal class Program
    {
        struct Point
        {
            public float x;
            public float y;
            public Point(float x, float y)
            {
                this.x = x;
                this.y = y;
            }
        }
        static void Main(string[] args)
        {
            //input
            int n = int.Parse(Console.ReadLine());
            Point[] stars = new Point[n];
            for(int i = 0; i < n; ++i)
            {
                string[] input = Console.ReadLine().Split();
                float x = float.Parse(input[0]);
                float y = float.Parse(input[1]);
                stars[i] = new Point(x, y);
            }

            //process
            //어떤 별로(int), 얼마나 거리가 떨어져있는지(float)
            PriorityQueue<(int, float), float> pq = new PriorityQueue<(int, float), float>();
            //시작은 0번 별부터
            bool[] visited = new bool[n];
            float result = 0f;

            //Prim 알고리즘
            pq.Enqueue((0, 0), 0);
            while (pq.Count > 0)
            {
                (int star, float prio) = pq.Dequeue();
                if (visited[star])
                    continue;

                visited[star] = true;
                result += prio;
                for(int i = 0; i < n; ++i)
                {
                    if(i != star)
                    {
                        float dist = GetDist(stars[i], stars[star]);
                        pq.Enqueue((i, dist), dist);
                    }
                }
            }
            Console.WriteLine(result);
        }

        static float GetDist(Point a, Point b)
        {
            float temp = (a.x - b.x) * (a.x - b.x) + (a.y - b.y) * (a.y - b.y);

            return MathF.Sqrt(temp);
        }
    }
}