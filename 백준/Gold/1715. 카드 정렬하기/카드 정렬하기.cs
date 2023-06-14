
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                pq.Enqueue(num, num);
            }

            int result = 0;
            while(pq.Count > 1)
            {
                int num1 = pq.Dequeue();
                int num2 = pq.Dequeue();
                int sum = num1 + num2;
                result += sum;
                pq.Enqueue(sum, sum);
            }
            Console.WriteLine(result);
        }
    }
}