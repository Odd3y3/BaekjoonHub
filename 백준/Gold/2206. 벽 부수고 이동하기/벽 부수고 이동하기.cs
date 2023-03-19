
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            int m = int.Parse(inputs[1]);
            bool[,] map = new bool[n, m];
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    if (input[j] == '1') map[i, j] = true;
                    else map[i, j] = false;
                }
            }

            Queue<QueueNode> queue = new Queue<QueueNode>();
            int[,] visitCheckTrue = new int[n, m];
            int[,] visitCheckFalse = new int[n, m];

            queue.Enqueue(new QueueNode(0, 0, true, 1));

            while(queue.Count > 0)
            {
                QueueNode node = queue.Dequeue();
                if (node.canBreak && visitCheckTrue[node.x, node.y] != 0) continue;
                if (!node.canBreak && visitCheckFalse[node.x, node.y] != 0) continue;

                if (node.canBreak)
                    visitCheckTrue[node.x, node.y] = node.depth;
                else
                    visitCheckFalse[node.x, node.y] = node.depth;

                //progress
                if (node.canBreak)
                {
                    if(node.x - 1 >= 0)
                    {
                        if (map[node.x - 1, node.y]) queue.Enqueue(new QueueNode(node.x - 1, node.y, false, node.depth + 1));
                        else queue.Enqueue(new QueueNode(node.x - 1, node.y, true, node.depth + 1));
                    }
                    if (node.y - 1 >= 0)
                    {
                        if (map[node.x, node.y - 1]) queue.Enqueue(new QueueNode(node.x, node.y - 1, false, node.depth + 1));
                        else queue.Enqueue(new QueueNode(node.x, node.y - 1, true, node.depth + 1));
                    }
                    if (node.x + 1 < n)
                    {
                        if (map[node.x + 1, node.y]) queue.Enqueue(new QueueNode(node.x + 1, node.y, false, node.depth + 1));
                        else queue.Enqueue(new QueueNode(node.x + 1, node.y, true, node.depth + 1));
                    }
                    if (node.y + 1 < m)
                    {
                        if (map[node.x, node.y + 1]) queue.Enqueue(new QueueNode(node.x, node.y + 1, false, node.depth + 1));
                        else queue.Enqueue(new QueueNode(node.x, node.y + 1, true, node.depth + 1));
                    }
                }
                else
                {
                    if (node.x - 1 >= 0 && !map[node.x - 1, node.y])
                    {
                        queue.Enqueue(new QueueNode(node.x - 1, node.y, false, node.depth + 1));
                    }
                    if (node.y - 1 >= 0 && !map[node.x, node.y - 1])
                    {
                        queue.Enqueue(new QueueNode(node.x, node.y - 1, false, node.depth + 1));
                    }
                    if (node.x + 1 < n && !map[node.x + 1, node.y])
                    {
                        queue.Enqueue(new QueueNode(node.x + 1, node.y, false, node.depth + 1));
                    }
                    if (node.y + 1 < m && !map[node.x, node.y + 1])
                    {
                        queue.Enqueue(new QueueNode(node.x, node.y + 1, false, node.depth + 1));
                    }
                }
            }
            //print result
            int result1 = visitCheckFalse[n - 1, m - 1];
            int result2 = visitCheckTrue[n - 1, m - 1];
            if (result1 == 0 && result2 == 0)
                Console.WriteLine(-1);
            else if (result2 == 0)
                Console.WriteLine(result1);
            else if (result1 == 0)
                Console.WriteLine(result2);
            else
                Console.WriteLine(Math.Min(result1, result2));
        }
        struct QueueNode
        {
            public int x;
            public int y;
            public bool canBreak;
            public int depth;
            public QueueNode(int x, int y, bool canBreak, int depth)
            {
                this.x = x;
                this.y = y;
                this.canBreak = canBreak;
                this.depth = depth;
            }
        }
    }
}