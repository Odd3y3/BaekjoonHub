
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            //보석 input
            (int, int)[] jewels = new (int, int)[n];
            for(int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                jewels[i] = (nums[0], nums[1]);
            }
            jewels = jewels.OrderBy(x => x.Item1).ToArray();

            //가방 input
            int[] bags = new int[k];
            for(int i = 0; i < k; i++)
            {
                int num = int.Parse(Console.ReadLine());
                bags[i] = num;
            }
            Array.Sort(bags);

            //progress
            PriorityQueue<int, int> pq = new PriorityQueue<int, int>();
            int bagIndex = 0;
            long result = 0;
            //보석을 세면서 계산
            for(int i = 0; i < n; i++)
            {
                while (bagIndex < k && jewels[i].Item1 > bags[bagIndex])
                {
                    if(pq.Count > 0)
                    {
                        result += pq.Dequeue();
                    }
                    bagIndex++;
                }

                pq.Enqueue(jewels[i].Item2, jewels[i].Item2 * (-1));
            }
            //남은 가방 수 만큼 추가 반복
            for(int i = 0; i < k - bagIndex; i++)
            {
                if (pq.Count > 0)
                {
                    result += pq.Dequeue();
                }
            }


            Console.WriteLine(result);
        }
    }
}