
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int test =  0; test < t; ++test)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int sum = 0;
                for(int i = 1; i <= input[0]; ++i)
                {
                    sum += input[i];
                }
                float avg = (float)sum / input[0];
                int count = 0;
                for(int i = 1; i <= input[0]; ++i)
                {
                    if (input[i] > avg)
                        count++;
                }
                float answer = (float)count * 100 / input[0];
                Console.WriteLine(string.Format("{0:0.000}%", answer));
            }
        }
    }
}