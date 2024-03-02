using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            List<int>[] info = new List<int>[n + 1];
            for (int i = 1; i <= n; ++i)
                info[i] = new List<int>();

            int[] count = new int[n + 1];

            for(int i = 0; i < m; ++i)
            {
                input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                info[a].Add(b);
                count[b]++;
            }

            //process
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            Queue<int> resultQueue = new Queue<int>();
            for(int i = 1; i <= n; ++i)
            {
                if (count[i] == 0)
                    pq.Enqueue(i, i);
            }

            while(pq.Count > 0)
            {
                int node = pq.Dequeue();
                resultQueue.Enqueue(node);
                foreach (int num in info[node])
                {
                    count[num]--;
                    if (count[num] == 0)
                        pq.Enqueue(num, num);
                }
            }

            //output
            StringBuilder sb = new StringBuilder();
            foreach (int item in resultQueue)
            {
                sb.Append(item);
                sb.Append(' ');
            }
            Console.WriteLine(sb);
        }
    }
}