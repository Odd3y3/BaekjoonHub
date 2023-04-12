
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAX_ARR_LENGTH = 2097153;     //2 ^ 21 + 1
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int k = int.Parse(input[2]);
            long[] arr = new long[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = long.Parse(Console.ReadLine());
            }

            long[] tree = new long[MAX_ARR_LENGTH];
            InitSegmentTree(1, 0, n - 1, tree, arr);

            //progress
            for (int i = 0; i < m + k; i++)
            {
                input = Console.ReadLine().Split();
                if (input[0] == "1")
                {
                    int index = int.Parse(input[1]) - 1;
                    long num = long.Parse(input[2]);
                    UpdateTree(1, 0, n - 1, index, num, tree);
                }
                else
                {
                    int start = int.Parse(input[1]) - 1;
                    int end = int.Parse(input[2]) - 1;
                    Console.WriteLine(GetSum(1, 0, n - 1, start, end, tree));
                }
            }
        }
        static long InitSegmentTree(int index, int start, int end, long[] tree, long[] input)
        {
            if(start == end)
            {
                tree[index] = input[start];
                return tree[index];
            }
            else
            {
                tree[index] = InitSegmentTree(index * 2, start, (start + end) / 2, tree, input)
                    + InitSegmentTree(index * 2 + 1, (start + end) / 2 + 1, end, tree, input);
                return tree[index];
            }
        }
        static long UpdateTree(int index, int start, int end, int numIndex, long num, long[] tree)
        {
            //if(numIndex >= start && numIndex <= end)
            //{
            //    tree[index] += addNum;
            //    if(start != end)
            //    {
            //        UpdateTree(index * 2, start, (start + end) / 2, numIndex, addNum, tree);
            //        UpdateTree(index * 2 + 1, (start + end) / 2 + 1, end, numIndex, addNum, tree);
            //    }
            //}

            if (numIndex < start || numIndex > end) return 0;
            else
            {
                if(start == end)
                {
                    long diff = num - tree[index];
                    tree[index] = num;
                    return diff;
                }
                else
                {
                    long diff = UpdateTree(index * 2, start, (start + end) / 2, numIndex, num, tree)
                        + UpdateTree(index * 2 + 1, (start + end) / 2 + 1, end, numIndex, num, tree);
                    tree[index] += diff;
                    return diff;
                }
            }
        }
        static long GetSum(int index, int start, int end, int answerStart, int answerEnd, long[] tree)
        {
            if (start > answerEnd || end < answerStart) return 0;
            else if (start >= answerStart && end <= answerEnd) return tree[index];
            else
            {
                return GetSum(index * 2, start, (start + end) / 2, answerStart, answerEnd, tree)
                    + GetSum(index * 2 + 1, (start + end) / 2 + 1, end, answerStart, answerEnd, tree);
            }
        }
    }
}
