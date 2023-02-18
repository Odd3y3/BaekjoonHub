using System;
using System.Text;

namespace MyTestingField
{
    class MinHeap
    {
        private long[] arr;
        public int Count;
        public MinHeap()
        {
            arr = new long[100002];
            Count = 0;
        }
        public void Push(long value)
        {
            Count++;
            arr[Count] = value;
            int index = Count;
            while (index > 1 && Math.Abs(arr[index / 2]) >= Math.Abs(arr[index]))
            {
                if (Math.Abs(arr[index / 2]) == Math.Abs(arr[index]) && arr[index] >= arr[index / 2])
                    break;

                long temp = arr[index / 2];
                arr[index / 2] = arr[index];
                arr[index] = temp;
                index /= 2;
            }
        }
        public long Pop()
        {
            if (Count == 0)
                return 0;
            long returnValue = arr[1];
            arr[1] = arr[Count];
            Count--;
            int index = 1;
            while (index * 2 <= Count)
            {
                int minIndex = 0;
                if (index * 2 == Count)
                    minIndex = index * 2;
                else
                {
                    if (Math.Abs(arr[index * 2]) > Math.Abs(arr[index * 2 + 1]))
                        minIndex = index * 2 + 1;
                    else if (Math.Abs(arr[index * 2]) < Math.Abs(arr[index * 2 + 1]))
                        minIndex = index * 2;
                    else
                        minIndex = arr[index * 2] > arr[index * 2 + 1] ? index * 2 + 1 : index * 2;
                }
                if (Math.Abs(arr[index]) >= Math.Abs(arr[minIndex]))
                {
                    if (Math.Abs(arr[index]) == Math.Abs(arr[minIndex]) && arr[index] <= arr[minIndex])
                        break;
                    long temp = arr[index];
                    arr[index] = arr[minIndex];
                    arr[minIndex] = temp;
                    index = minIndex;
                }
                else break;
            }

            return returnValue;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            MinHeap minHeap = new MinHeap();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                long x = long.Parse(Console.ReadLine());
                if (x == 0)
                    sb.AppendLine(minHeap.Pop().ToString());
                else
                    minHeap.Push(x);
            }
            Console.WriteLine(sb);
        }
    }
}