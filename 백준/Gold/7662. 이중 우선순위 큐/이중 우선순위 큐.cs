using System;
using System.Text;

namespace MyTestingField
{
    class PriorityQueue
    {
        public long[] arr;
        public long count;
        public PriorityQueue()
        {
            count = 0;
            arr = new long[2000000];
        }
        public void Push(long value)
        {
            count++;
            arr[count] = value;
            long index = count;
            while(index > 1)
            {
                if (arr[index] < arr[index / 2])
                {
                    long temp = arr[index / 2];
                    arr[index / 2] = arr[index];
                    arr[index] = temp;
                    index /= 2;
                }
                else break;
            }
        }
        public long Pop()
        {
            if (count == 0)
                return 0;
            long returnValue = arr[1];
            arr[1] = arr[count];
            arr[count] = 0;
            count--;
            long index = 1;
            while(index * 2 <= count)
            {
                long minIndex = 0;
                if (index * 2 == count)
                    minIndex = index * 2;
                else
                    minIndex = arr[index * 2] > arr[index * 2 + 1] ? index * 2 + 1 : index * 2;

                if (arr[index] > arr[minIndex])
                {
                    long temp = arr[index];
                    arr[index] = arr[minIndex];
                    arr[minIndex] = temp;
                    index = minIndex;
                }
                else break;
            }
            return returnValue;
        }
        public long Peek()
        {
            return arr[1];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            long t = long.Parse(Console.ReadLine());
            for(long i = 0; i < t; i++)
            {
                PriorityQueue minPQ = new PriorityQueue();
                PriorityQueue maxPQ = new PriorityQueue();
                PriorityQueue deletedMinPQ = new PriorityQueue();
                PriorityQueue deletedMaxPQ = new PriorityQueue();
                long k = long.Parse(Console.ReadLine());
                for(int j = 0; j < k; j++)
                {
                    string[] input = Console.ReadLine().Split(' ');
                    long n = long.Parse(input[1]);
                    if (input[0] == "I")
                    {
                        minPQ.Push(n);
                        maxPQ.Push(n * (-1));
                    }
                    else if(n == -1)
                    {
                        while(minPQ.count > 0 && deletedMinPQ.count > 0 && minPQ.Peek() == deletedMinPQ.Peek())
                        {
                            minPQ.Pop();
                            deletedMinPQ.Pop();
                        }
                        if(minPQ.count > 0)
                        {
                            long value = minPQ.Pop();
                            deletedMaxPQ.Push(value *(-1));
                        }
                    }
                    else if(n == 1)
                    {
                        while (maxPQ.count > 0 && deletedMaxPQ.count > 0 && maxPQ.Peek() == deletedMaxPQ.Peek())
                        {
                            maxPQ.Pop();
                            deletedMaxPQ.Pop();
                        }
                        if(maxPQ.count > 0)
                        {
                            long value = maxPQ.Pop();
                            deletedMinPQ.Push(value * (-1));
                        }
                    }
                }
                
                if (minPQ.count == deletedMinPQ.count)
                    sb.AppendLine("EMPTY");
                else
                {
                    while (minPQ.count > 0 && deletedMinPQ.count > 0 && minPQ.Peek() == deletedMinPQ.Peek())
                    {
                        minPQ.Pop();
                        deletedMinPQ.Pop();
                    }
                    while (maxPQ.count > 0 && deletedMaxPQ.count > 0 && maxPQ.Peek() == deletedMaxPQ.Peek())
                    {
                        maxPQ.Pop();
                        deletedMaxPQ.Pop();
                    }
                    sb.Append(maxPQ.Pop() * (-1));
                    sb.Append(" ");
                    sb.AppendLine(minPQ.Pop().ToString());
                }
            }
            Console.WriteLine(sb);
        }
    }
}
