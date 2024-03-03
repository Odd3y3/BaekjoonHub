
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            
            PriorityQueue<int, int> leftPQ= new PriorityQueue<int, int>();
            PriorityQueue<int, int> rightPQ= new PriorityQueue<int, int>();
            //첫 번째
            int num = int.Parse(Console.ReadLine());
            leftPQ.Enqueue(num, -num);
            sb.AppendLine(num.ToString());
            //첫 번째 이후
            for(int i = 1; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if(num > leftPQ.Peek())
                {
                    rightPQ.Enqueue(num, num);
                }
                else
                {
                    leftPQ.Enqueue(num, -num);
                }

                if(leftPQ.Count > rightPQ.Count + 1)
                {
                    int v = leftPQ.Dequeue();
                    rightPQ.Enqueue(v, v);
                }
                else if(rightPQ.Count > leftPQ.Count)
                {
                    int v = rightPQ.Dequeue();
                    leftPQ.Enqueue(v, -v);
                }

                sb.AppendLine(leftPQ.Peek().ToString());
            }

            Console.WriteLine(sb);
        }
    }
}