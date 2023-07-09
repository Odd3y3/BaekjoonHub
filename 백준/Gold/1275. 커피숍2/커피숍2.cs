
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
            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();

            //process
            SegmentTree st = new SegmentTree(arr);

            //output
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < m; ++i)
            {
                input = Console.ReadLine().Split();
                int start = int.Parse(input[0]) - 1;
                int end = int.Parse(input[1]) - 1;

                if(start > end)
                {
                    start = start ^ end;
                    end = start ^ end;
                    start = start ^ end;
                }

                int numIndex = int.Parse(input[2]) - 1;
                long value = long.Parse(input[3]);
                sb.AppendLine(st.GetSum(start, end).ToString());

                if(numIndex >= 0 && numIndex < arr.Length)
                {
                    st.ChangeNum(numIndex, arr[numIndex], value);
                    arr[numIndex] = value;
                }
            }

            Console.WriteLine(sb);
        }   
    }

    class SegmentTree
    {
        Node[] tree;

        public SegmentTree(long[] array)
        {
            tree = new Node[array.Length * 4];
            Init(1, 0, array.Length - 1, array);
        }

        private long Init(int index, int start, int end, long[] array)
        {
            if(start == end)
            {
                tree[index] = new Node(start, end, array[start]);
                return array[start];
            }

            int middleIndex = (start + end) / 2;
            long sum = Init(index * 2, start, middleIndex, array) + Init(index * 2 + 1, middleIndex + 1, end, array);
            tree[index] = new Node(start, end, sum);
            return sum;
        }

        public long GetSum(int start, int end)
        {
            return RecursiveGetSum(1, start, end);
        }

        private long RecursiveGetSum(int index, int start, int end)
        {
            Node node = tree[index];
            if (node.Start >= start && node.End <= end)
                return node.Sum;
            if (node.Start > end || node.End < start)
                return 0;

            long leftValue = RecursiveGetSum(index * 2, start, end);
            long rightValue = RecursiveGetSum(index * 2 + 1, start, end);

            return leftValue + rightValue;
        }

        public void ChangeNum(int numIndex, long originValue, long value)
        {
            RecursiveChangeNum(1, numIndex, originValue, value);
        }

        private void RecursiveChangeNum(int index, int numIndex, long originValue, long value)
        {
            Node node = tree[index];
            if(node.Start <= numIndex && node.End >= numIndex)
            {
                Node newNode = new Node(node.Start, node.End, node.Sum + value - originValue);
                tree[index] = newNode;

                
                if(node.Start != node.End)
                {
                    RecursiveChangeNum(index * 2, numIndex, originValue, value);
                    RecursiveChangeNum(index * 2 + 1, numIndex, originValue, value);
                }
            }
        }
    }

    struct Node
    {
        public int Start { get; }
        public int End { get; }
        public long Sum { get; }
        public Node(int start, int end, long sum)
        {
            this.Start = start;
            this.End = end;
            this.Sum = sum;
        }
    }
}