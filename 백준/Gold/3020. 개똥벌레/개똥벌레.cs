
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int h = int.Parse(input[1]);
            int[] answerArr = new int[h];

            int[] arr1 = new int[h];
            int[] arr2 = new int[h];

            for (int i = 0; i < n; ++i)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    ++arr1[num];
                }
                else
                {
                    ++arr2[num];
                }
            }

            int arr1len = n - (n / 2);
            int arr2len = n / 2;

            for (int i = 0; i < h; ++i)
            {
                arr1len -= arr1[i];
                answerArr[i] += arr1len;
            }
            for (int i = 0; i < h; ++i)
            {
                arr2len -= arr2[i];
                answerArr[h - i - 1] += arr2len;
            }

            int min = answerArr.Min();
            int answer = 0;
            foreach (int i in answerArr)
            {
                if (i == min)
                    ++answer;
            }
            Console.WriteLine($"{min} {answer}");
        }
    }
}