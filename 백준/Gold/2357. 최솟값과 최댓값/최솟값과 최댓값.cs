
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
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                (int a, int b) = st.GetMinMax(nums[0] - 1, nums[1] - 1);
                sb.Append(a);
                sb.Append(" ");
                sb.AppendLine(b.ToString());
            }
            Console.WriteLine(sb.ToString());   
        }
    }

    class SegmentTree
    {
        private Node[] tree;
        //private int 

        public SegmentTree(int[] array)
        {
            this.tree = new Node[array.Length * 4];
            Init(1, 0, array.Length - 1, array);
        }

        private Node Init(int index, int start, int end, int[] array)
        {
            if(start == end)
            {
                tree[index] = new Node(start, end, array[start], array[start]);
                return tree[index];
            }

            int middleIndex = (end + start) / 2;
            Node leftNode = Init(index * 2, start, middleIndex, array);
            Node rightNode = Init(index * 2 + 1, middleIndex + 1, end, array);
            int minValue = Math.Min(leftNode.MinValue, rightNode.MinValue);
            int maxValue = Math.Max(leftNode.MaxValue, rightNode.MaxValue);
            tree[index] = new Node(start, end, minValue, maxValue);
            return tree[index];
        }

        public (int, int) GetMinMax(int start, int end)
        {
            return RecurrsiveGetMinMax(1, start, end);
        }

        private (int, int) RecurrsiveGetMinMax(int index, int start, int end)
        {
            Node node = tree[index];
            if(node.Start >= start && node.End <= end)
                return (node.MinValue, node.MaxValue);
            if (node.Start > end || node.End < start)
                return (int.MaxValue, int.MinValue);
            
            int leftMin, rightMin, leftMax, rightMax;
            (leftMin, leftMax) = RecurrsiveGetMinMax(index * 2, start, end);
            (rightMin, rightMax) = RecurrsiveGetMinMax(index * 2 + 1, start, end);

            return (Math.Min(leftMin, rightMin), Math.Max(leftMax, rightMax));
        }
    }

    struct Node
    {
        public int Start { get; }
        public int End { get; }
        public int MinValue { get; }
        public int MaxValue { get; }

        public Node(int start, int end, int min, int max)
        {
            Start = start;
            End = end;
            MinValue = min;
            MaxValue = max;
        }
    }
}