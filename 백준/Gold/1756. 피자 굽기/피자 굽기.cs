
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int d = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int minValue = int.MaxValue;
            int[] oven = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            for(int i = 0; i < d; i++)
            {
                if (oven[i] < minValue)
                    minValue = oven[i];
                else
                    oven[i] = minValue;
            }
            Queue<int> queue = new Queue<int>();
            foreach (var item in Console.ReadLine().Split(' ').Select(x => int.Parse(x)))
            {
                queue.Enqueue(item);
            }

            int top = d;
            for(int i = d - 1; i >= 0; i--)
            {
                if (queue.Count == 0)
                    break;
                if (oven[i] >= queue.Peek())
                {
                    queue.Dequeue();
                    top = i;
                }
            }
            if (queue.Count > 0)
                Console.WriteLine(0);
            else
                Console.WriteLine(top + 1);
        }
    }
}