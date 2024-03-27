
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int k = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[] primes = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            PriorityQueue<long, long> pq = new PriorityQueue<long, long>();
            //중복검사 Dictionary
            Dictionary<long, bool> dict = new Dictionary<long, bool>();

            //init
            foreach (var num in primes)
            {
                pq.Enqueue(num, num);
            }

            //process
            int i = 0;
            long prevNum = 0;
            long maxValue = primes[primes.Length - 1];
            while(i < n - 1)
            {
                long value = pq.Dequeue();

                foreach (int num in primes)
                {
                    long temp = value * num;

                    //이미 나온 숫자면 넣지 않음
                    if (dict.ContainsKey(temp))
                        continue;

                    //범위 초과하면 넣지않음
                    if (temp > int.MaxValue)
                        continue;

                    //pq가 n을 넘어가고, 최대값보다 크면 넣지않음
                    if (pq.Count > n && temp >= maxValue)
                        continue;

                    pq.Enqueue(temp, temp);
                    dict.Add(temp, true);
                    if (temp > maxValue)
                        maxValue = temp;
                }

                prevNum = value;
                i++;
            }

            Console.WriteLine(pq.Dequeue());
        }
    }
}