
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] sortedArr = HeapSort(arr);
            Dictionary<int, Queue<int>> dict = new Dictionary<int, Queue<int>>();
            for(int i = 0; i < n; i++)
            {
                if (!dict.ContainsKey(arr[i]))
                    dict.Add(arr[i], new Queue<int>());

                dict[arr[i]].Enqueue(i);
            }

            int result = 0;
            for(int i = 0; i < n; ++i)
            {
                int value = dict[sortedArr[i]].Dequeue() - i;
                if (result < value)
                    result = value;
            }

            Console.WriteLine(result + 1);
        }

        static int[] HeapSort(int[] arr)
        {
            int[] result = new int[arr.Length];

            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            foreach (int item in arr)
            {
                pq.Enqueue(item, item);
            }

            for(int i = 0; i < arr.Length; i++)
            {
                result[i] = pq.Dequeue();
            }
            return result;
        }
    }
}