
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int>[] arr = new List<int>[n + 1];
            int[] input;
            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                if (arr[input[0]] == null)
                    arr[input[0]] = new List<int>();
                arr[input[0]].Add(input[1]);
            }

            //progress
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            int result = 0;
            for(int i = n; i > 0; i--)
            {
                if (arr[i] != null)
                {
                    foreach (int item in arr[i])
                    {
                        pq.Enqueue(item, -item);
                    }
                }

                if(pq.Count > 0)
                {
                    result += pq.Dequeue();
                }
            }

            Console.WriteLine(result);
        }
    }
}                           