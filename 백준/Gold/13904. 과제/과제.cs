
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int>[] lists = new List<int>[1000];
            for (int i = 0; i < 1000; ++i)
            {
                lists[i] = new List<int>();
            }

            //input
            string[] input;
            for (int i = 0; i < n; ++i)
            {
                input = Console.ReadLine().Split();
                int d = int.Parse(input[0]);
                int w = int.Parse(input[1]);
                lists[d - 1].Add(w);
            }

            //정렬
            for (int i = 0; i < 1000; ++i)
            {
                lists[i].Sort();
                lists[i].Reverse();
            }

            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            for (int i = 0; i < 1000; ++i)
            {
                if (lists[i].Count == 0)
                {
                    //list에 아무것도 없으면 0을 넣음
                    pq.Enqueue(0, 0);
                }
                else
                {
                    if (pq.Count > 0)
                    {
                        for (int j = 1; j < lists[i].Count; ++j)
                        {
                            if (lists[i][j] > pq.Peek())
                            {
                                pq.Dequeue();
                                pq.Enqueue(lists[i][j], lists[i][j]);
                            }
                            else
                                break;

                        }
                    }
                    pq.Enqueue(lists[i][0], lists[i][0]);
                }
            }

            int result = 0;
            while(pq.Count > 0)
            {
                result += pq.Dequeue();
            }
            Console.WriteLine(result);
        }
    }
}