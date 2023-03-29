
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            List<(int, int)>[] graph = new List<(int, int)>[n + 1];
            for (int i = 1; i <= n; i++)
                graph[i] = new List<(int, int)>();
            for(int i = 0; i < m; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                graph[input[0]].Add((input[1], input[2]));
            }
            string[] strInput = Console.ReadLine().Split();
            int start = int.Parse(strInput[0]);
            int end = int.Parse(strInput[1]);

            //다익스트라
            PriorityQueue<Node, int> pq = new PriorityQueue<Node, int>();
            bool[] visit = new bool[n + 1];

            (int, List<int>)[] result = new (int, List<int>)[n + 1]; // (distance , 경로)
            for(int i = 1; i <= n; i++)
            {
                result[i].Item1 = int.MaxValue;
                result[i].Item2 = new List<int> { i };
            }

            pq.Enqueue(new Node(start, 0), 0);

            while(pq.Count > 0)
            {
                Node currentNode = pq.Dequeue();
                if (!visit[currentNode.node])
                {
                    visit[currentNode.node] = true;
                    result[currentNode.node] = (currentNode.distance, currentNode.route);
                    foreach (var item in graph[currentNode.node])
                    {
                        Node nextNode = new Node(item.Item1, currentNode.distance + item.Item2);
                        List<int> newRoute = new List<int>();
                        foreach (var routeValue in currentNode.route)
                        {
                            newRoute.Add(routeValue);
                        }
                        nextNode.route = newRoute;
                        nextNode.route.Add(item.Item1);
                        pq.Enqueue(nextNode, currentNode.distance + item.Item2);
                    }
                }
            }

            //output
            Console.WriteLine(result[end].Item1);
            Console.WriteLine(result[end].Item2.Count);
            Console.WriteLine(string.Join(' ', result[end].Item2));
        }
    }
    struct Node
    {
        public int node;
        public int distance;
        public List<int> route;
        public Node(int node, int distance)
        {
            this.node = node;
            this.distance = distance;
            route = new List<int> { node };
        }
    }
}