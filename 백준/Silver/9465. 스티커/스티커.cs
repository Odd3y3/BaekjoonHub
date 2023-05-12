
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int test = 0; test < t; test++)
            {
                int n = int.Parse(Console.ReadLine());
                int[] arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int[] arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

                int prev1 = arr1[0];
                int prev2 = arr2[0];
                int prev0 = 0;
                int curr1 = prev1;
                int curr2 = prev2;
                int curr0 = 0;
                for(int i = 1; i < n; i++)
                {
                    curr1 = Math.Max(prev2 + arr1[i], prev0 + arr1[i]);
                    curr2 = Math.Max(prev1 + arr2[i], prev0 + arr2[i]);
                    curr0 = Math.Max(prev1, prev2);
                    prev1 = curr1;
                    prev2 = curr2;
                    prev0 = curr0;
                }
                int[] answers = {prev1, prev2, prev0};
                Console.WriteLine(answers.Max());
            }
        }
    }
}

