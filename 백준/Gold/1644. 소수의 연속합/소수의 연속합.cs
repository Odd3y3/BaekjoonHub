
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //에라토스테네스의 체
            bool[] prime = Enumerable.Repeat(true, n + 1).ToArray();
            prime[0] = false;
            prime[1] = false;
            for(int i = 2; i < Math.Sqrt(n) + 1; i++)
            {
                if (prime[i])
                {
                    for(int j = i + i; j <= n; j += i)
                    {
                        if (prime[j])
                        {
                            prime[j] = false;
                        }
                    }
                }
            }
            List<int> list = new List<int>();
            for(int i = 2; i <= n; i++)
            {
                if (prime[i])
                {
                    list.Add(i);
                }
            }
            int[] primeArr = list.ToArray();
            int length = primeArr.Length;

            //progress
            int sum = 0;
            int minIndex = 0;
            int result = 0;

            for(int i = 0; i < length; i++)
            {
                sum += primeArr[i];
                while(sum > n)
                {
                    sum -= primeArr[minIndex];
                    minIndex++;
                }
                if(sum == n)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}