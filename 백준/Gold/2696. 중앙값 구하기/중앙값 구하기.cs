
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            for (int test = 0; test < t; test++)
            {
                int m = int.Parse(Console.ReadLine());
                int[] nums = new int[m];
                int[] input;
                for(int i = 0; i < (m / 10) + 1; i++)
                {
                    input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                    for(int j = 0; j < input.Length; j++)
                    {
                        nums[i * 10 + j] = input[j];
                    }
                }

                PriorityQueue<int, int> leftPQ = new PriorityQueue<int, int>();
                PriorityQueue<int, int> rightPQ = new PriorityQueue<int, int>();
                List<int> resultList = new List<int>();
                leftPQ.Enqueue(nums[0], -nums[0]);
                resultList.Add(nums[0]);
                for(int i = 1; i < m; i++)
                {
                    if (nums[i] <= leftPQ.Peek())
                        leftPQ.Enqueue(nums[i], -nums[i]);
                    else
                        rightPQ.Enqueue(nums[i], nums[i]);

                    int temp = 0;
                    if (leftPQ.Count > rightPQ.Count + 1)
                    {
                        temp = leftPQ.Dequeue();
                        rightPQ.Enqueue(temp, temp);
                    }
                    else if (leftPQ.Count < rightPQ.Count)
                    {
                        temp = rightPQ.Dequeue();
                        leftPQ.Enqueue(temp, -temp);
                    }

                    if (i % 2 == 0)
                        resultList.Add(leftPQ.Peek());
                }


                //output
                sb.Append(resultList.Count);

                for(int i = 0; i < resultList.Count; i++)
                {
                    if (i % 10 == 0)
                        sb.AppendLine();

                    sb.Append(resultList[i]);
                    sb.Append(' ');
                }
                sb.AppendLine();
            }

            Console.WriteLine(sb);
        }
    }
}                           