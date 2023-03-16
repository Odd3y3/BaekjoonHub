
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Dictionary<long, long> visitDict = new Dictionary<long, long>();
            Console.WriteLine(Func(n + 1, visitDict));
        }
        static long Func(long n, Dictionary<long, long> visitDict)
        {
            long first;
            long second;
            if (n <= 3)
            {
                switch (n)
                {
                    case 1:
                        return 0;
                        break;
                    case 2:
                    case 3:
                        return 1;
                        break;
                    default:
                        return -1;
                        break;
                }
            }
            else if (visitDict.ContainsKey(n))
            {
                return visitDict[n];
            }
            else if (n % 2 == 0)
            {
                first = Func(n / 2, visitDict);
                second = Func((n / 2) + 1, visitDict);
                long temp = ((first * first) + (second * second)) % 1000000007;
                visitDict.Add(n, temp);
                return temp;
            }
            else
            {
                first = Func((n + 3) / 2, visitDict);
                second = Func((n - 1) / 2, visitDict);
                long temp = ((first * first) - (second * second)) % 1000000007;
                temp = temp >= 0 ? temp : temp + 1000000007;
                visitDict.Add(n, temp);
                return temp;
            }
        }
    }
}