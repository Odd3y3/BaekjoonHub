
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            List<int> list = new List<int>();

            list.Add(arr[0]);
            for(int i = 1; i < n; i++)
            {
                Func(arr[i], list);
            }

            Console.WriteLine(list.Count);
        }
        static void Func(int n, List<int> list)
        {
            if (n > list[list.Count - 1])
                list.Add(n);
            else
            {
                BSInsert(n, 0, list.Count - 1, list);
            }
        }

        static void BSInsert(int n, int start, int end, List<int> list)
        {
            if(start == end)
            {
                list[start] = n;
            }
            else
            {
                int midIdx = (start + end) / 2;
                if (list[midIdx] > n)
                {
                    BSInsert(n, start, midIdx, list);
                }
                else
                {
                    BSInsert(n, midIdx + 1, end, list);
                }
            }
        }
    }
}                           