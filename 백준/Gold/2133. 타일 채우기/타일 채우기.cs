
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n % 2 != 0)
                Console.WriteLine(0);
            else
            {
                n = n / 2;
                int[] answers = new int[n + 1];
                answers[0] = 1;
                answers[1] = 3;
                int sum = 1;
                for(int i = 2; i <= n; i++)
                {
                    answers[i] += answers[i - 1] * 3 + sum * 2;
                    sum += answers[i - 1];
                }
                Console.WriteLine(answers[n]);
            }
        }
    }
}

