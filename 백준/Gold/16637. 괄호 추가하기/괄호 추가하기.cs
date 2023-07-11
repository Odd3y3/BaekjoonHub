
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] nums = new int[n / 2];
            char[] opers = new char[n / 2];

            int[] minDp = new int[n / 2 + 1];
            int[] maxDp = new int[n / 2 + 1];
            minDp[0] = input[0] - '0';
            maxDp[0] = input[0] - '0';
            for (int i = 1; i < n; ++i)
            {
                if (i % 2 == 0)
                {
                    //숫자
                    nums[i / 2 - 1] = input[i] - '0';
                }
                else
                {
                    //연산자
                    opers[i / 2] = input[i];
                }
            }

            //process
            List<int> list = new List<int>();
            for (int i = 1; i <= n / 2; ++i)
            {
                list.Clear();
                list.Add(Oper(minDp[i - 1], opers[i - 1], nums[i - 1]));
                list.Add(Oper(maxDp[i - 1], opers[i - 1], nums[i - 1]));

                if (i > 1)
                {
                    int temp = Oper(nums[i - 2], opers[i - 1], nums[i - 1]);
                    list.Add(Oper(minDp[i - 2], opers[i - 2], temp));
                    list.Add(Oper(maxDp[i - 2], opers[i - 2], temp));
                }
                minDp[i] = list.Min();
                maxDp[i] = list.Max();
            }

            Console.WriteLine(maxDp[n / 2]);
        }

        static int Oper(int first, char oper, int second)
        {
            switch (oper)
            {
                case '+':
                    return first + second;
                case '-':
                    return first - second;
                case '*':
                    return first * second;
                default:
                    return 0;
            }
        }
    }
}