
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
            int[] arr = new int[n];
            for(int i = 0; i < n; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //process
            SegmentTree st = new SegmentTree(arr);

            //output
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < m; ++i)
            {
                input = Console.ReadLine().Split();
                int start = int.Parse(input[0]) - 1;
                int end = int.Parse(input[1]) - 1;
                sb.AppendLine(st.GetMinValue(start, end).ToString());
            }

            Console.WriteLine(sb);
        }   
    }

    class SegmentTree
    {
        Node[] tree;

        public SegmentTree(int[] array)
        {
            tree = new Node[array.Length * 4];
            Init(1, 0, array.Length - 1, array);
        }

        private int Init(int index, int start, int end, int[] array)
        {
            if(start == end)
            {
                tree[index] = new Node(start, end, array[start]);
                return array[start];
            }

            int middleIndex = (start + end) / 2;
            int minValue = Math.Min(Init(index * 2, start, middleIndex, array), Init(index * 2 + 1, middleIndex + 1, end, array));
            tree[index] = new Node(start, end, minValue);
            return minValue;
        }

        public int GetMinValue(int start, int end)
        {
            return RecursiveGetMinValue(1, start, end);
        }

        private int RecursiveGetMinValue(int index, int start, int end)
        {
            Node node = tree[index];
            if (node.Start >= start && node.End <= end)
                return node.MinValue;
            if (node.Start > end || node.End < start)
                return int.MaxValue;

            int leftMinValue = RecursiveGetMinValue(index * 2, start, end);
            int rightMinValue = RecursiveGetMinValue(index * 2 + 1, start, end);

            return Math.Min(leftMinValue, rightMinValue);
        }
    }

    struct Node
    {
        public int Start { get; }
        public int End { get; }
        public int MinValue { get; }
        public Node(int start, int end, int minValue)
        {
            this.Start = start;
            this.End = end;
            this.MinValue = minValue;
        }
    }
}