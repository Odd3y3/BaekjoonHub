
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long min = long.Parse(input[0]);
            long max = long.Parse(input[1]);
            

            //소수를 먼저 구함 1000010까지
            bool[] isPrime = Enumerable.Repeat(true, 1000011).ToArray();
            Eratos(isPrime);

            //소수 제곱 구하기
            List<long> powPrimeList = new List<long>();
            for(long i = 2; i <= 1000010; i++)
            {
                if (isPrime[i])
                    powPrimeList.Add(i * i);
            }

            //min~ max 제곱 ㅇㅇ수 구해서 빼면 그게 제곱 ㄴㄴ수
            long length = max - min + 1;
            bool[] arr = Enumerable.Repeat(true, (int)length).ToArray();  //index + min 하면 그게 그 수임
            foreach (long item in powPrimeList)
            {
                long temp = (item - (min % item)) % item;
                for(long i = temp; i < length; i += item)
                {
                    arr[i] = false;
                }
            }

            //output
            int result = 0;
            foreach (var item in arr)
            {
                if (item) result++;
            }
            Console.WriteLine(result);
        }
        static void Eratos(bool[] isPrime)
        {
            isPrime[0] = false;
            isPrime[1] = false;
            for(int i = 2; i <= 1001; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i + i; j <= 1000010; j += i)
                        isPrime[j] = false;
                }
            }
        }
    }
}