
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> gasStations = new Dictionary<int, int>();
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();

            int[] input;
            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                gasStations.Add(input[0], input[1]);
                pq.Enqueue(input[0], input[0]);
            }

            input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int destination = input[0];
            List<int> dp = new List<int>();
            dp.Add(input[1]);
            int curPos = 0;

            while(pq.Count > 0)
            {
                int nextPos = pq.Dequeue();
                List<int> newDp = new List<int>();
                for (int i = 0; i <= dp.Count; i++)
                    newDp.Add(-1);
                for(int i = 0; i < dp.Count; i++)
                {
                    if (dp[i] < 0)
                        continue;

                    if (dp[i] - (nextPos - curPos) > newDp[i])
                        newDp[i] = dp[i] - (nextPos - curPos);
                    if(dp[i] - (nextPos - curPos) >= 0)
                        newDp[i + 1] = dp[i] - (nextPos - curPos) + gasStations[nextPos];
                }
                curPos = nextPos;
                dp = newDp;
            }


            int result = -1;
            for(int i = 0; i < dp.Count; ++i)
            {
                if (dp[i] - (destination - curPos) >= 0)
                {
                    result = i;
                    break;
                }
            }

            Console.WriteLine(result);
        }
    }
}