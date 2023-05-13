
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int[] arr = new int[n];
            for(int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int[] answers = new int[k + 1];
            answers[0] = 1;
            foreach (var item in arr)
            {
                for(int i = item; i <= k; i++)
                {
                    answers[i] = answers[i] + answers[i - item];
                }
            }
            Console.WriteLine(answers[k]);
        }
    }
}

