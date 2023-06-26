namespace TestField
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            bool[,] map = new bool[n, 2];
            bool[,] visit = new bool[n, 2];
            string inputString1 = Console.ReadLine();
            string inputString2 = Console.ReadLine();
            for (int i = 0; i < n; i++)
            {
                if (inputString1[i] == '1')
                    map[i, 0] = true;
                if (inputString2[i] == '1')
                    map[i, 1] = true;
            }

            //너비 우선
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(new Node(0, 0, 0));
            bool isClear = false;
            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();
                if (node.x < node.turn)
                    continue;
                if (node.x >= n)
                {
                    isClear = true;
                    break;
                }
                if (!map[node.x, node.y])
                    continue;

                //방문햇던곳은 패스
                if (visit[node.x, node.y])
                    continue;
                else
                    visit[node.x, node.y] = true;

                queue.Enqueue(new Node(node.x + k, node.y ^ 1, node.turn + 1));
                queue.Enqueue(new Node(node.x + 1, node.y, node.turn + 1));
                queue.Enqueue(new Node(node.x - 1, node.y, node.turn + 1));

            }
            if (isClear)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }

        struct Node
        {
            //현재 위치 정보
            public int x;
            public int y;
            //현재 턴 정보
            public int turn;
            public Node(int x, int y, int turn)
            {
                this.x = x;
                this.y = y;
                this.turn = turn;
            }
        }
    }
}