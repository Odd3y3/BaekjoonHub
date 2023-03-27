
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            //입력 데이터
            int n = int.Parse(sr.ReadLine());
            List<int>[] graph = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
                graph[i] = new List<int>();
            for(int i = 0; i < n - 1; i++)
            {
                int[] input = sr.ReadLine().Split().Select(int.Parse).ToArray();
                graph[input[0]].Add(input[1]);
                graph[input[1]].Add(input[0]);
            }
            int[] startNode = sr.ReadLine().Split().Select(int.Parse).ToArray();

            //progress
            bool canEscape = false;
            if (graph[startNode[0]].Count != 2)
                canEscape = true;
            else
            {
                bool isLeft1, isLeft2;
                int depth1, depth2;
                int leftDepth = 200000, rightDepth = 200000;
                (isLeft1, depth1,isLeft2, depth2) = GetDepthTargetNode(startNode[0], startNode[1], startNode[2], graph, ref leftDepth, ref rightDepth);
                if(!(isLeft1 ^ isLeft2))
                    canEscape = true;
                else
                {
                    

                    //결과
                    if (isLeft1) //depth1 이 left
                    {
                        if (depth1 > leftDepth * 2)
                            canEscape = true;
                        if (depth2 > rightDepth * 2)
                            canEscape = true;
                    }
                    else
                    {
                        if (depth2 > leftDepth * 2)
                            canEscape = true;
                        if (depth1 > rightDepth * 2)
                            canEscape = true;
                    }
                }

            }

            if (canEscape)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
        static (bool, int, bool, int) GetDepthTargetNode(int start, int target1, int target2, List<int>[] graph, ref int leftDepth, ref int rightDepth)
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(new Node(graph[start][0], 1, true, start));
            queue.Enqueue(new Node(graph[start][1], 1, false, start));
            Node node1 = new Node();
            Node node2 = new Node();
            bool flag1 = false;
            bool flag2 = false;
            bool flagLeft = true;
            bool flagRight = true;
            while(queue.Count > 0)
            {
                Node current = queue.Dequeue();
                if(current.isLeft && graph[current.nodeNum].Count > 2 && flagLeft)
                {
                    flagLeft = false;
                    leftDepth = current.depth;
                }
                if (!current.isLeft && graph[current.nodeNum].Count > 2 && flagRight)
                {
                    flagRight = false;
                    rightDepth = current.depth;
                }
                if (current.nodeNum == target1)
                {
                    node1 = current;
                    flag1 = true;
                }
                if (current.nodeNum == target2)
                {
                    node2 = current;
                    flag2 = true;
                }
                if (flag1 && flag2) break;
                foreach (var item in graph[current.nodeNum])
                {
                    if (item != current.parent)
                        queue.Enqueue(new Node(item, current.depth + 1, current.isLeft, current.nodeNum));
                }
            }

            return (node1.isLeft, node1.depth, node2.isLeft, node2.depth);
        }
        class Node
        {
            public int nodeNum;
            public int depth;
            public bool isLeft;
            public int parent;
            public Node(int nodeNum, int depth, bool isLeft, int parent)
            {
                this.nodeNum= nodeNum;
                this.depth= depth;
                this.isLeft= isLeft;
                this.parent= parent;
            }
            public Node() { }
        }
    }
}