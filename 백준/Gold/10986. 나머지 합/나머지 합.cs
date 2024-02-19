
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            int[] a = Console.ReadLine().Split().Select(x => int.Parse(x) % m).ToArray();
            
            //arr는 누적 합의 m으로 나눈 나머지, 의 갯수 ( ex. arr[0]은 나머지가 0인 수의 개수 )
            int[] arr = new int[m + 1];
            arr[0] = 1;
            int sum = 0;
            foreach (int item in a)
            {
                sum = (sum + item) % m;
                ++arr[sum];
            }

            long result = 0;
            foreach (int item in arr)
            {
                if (item < 2)
                    continue;
                result += (long)item * (item - 1) / 2;
            }

            Console.WriteLine(result);
        }

    }
}