namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            long a = long.Parse(input[0]);
            long b = long.Parse(input[1]);
            Console.WriteLine(SumFunc(b) - SumFunc(a - 1));
        }

        static long SumFunc(long n)
        {
            List<bool> biNum = new List<bool>();
            long temp = n;
            while(temp > 0)
            {
                long d = temp % 2; //나머지
                if (d == 0)
                    biNum.Add(false);
                else
                    biNum.Add(true);
                temp /= 2;
            }

            temp = 0;
            long result = 0;
            for(int i = biNum.Count - 1; i >= 0; --i)
            {
                if (biNum[i])
                {
                    result += (long)Math.Pow(2, i - 1) * i + temp * (long)Math.Pow(2, i);
                    ++temp;
                }
            }
            result += temp;

            return result;
        }
    }
}