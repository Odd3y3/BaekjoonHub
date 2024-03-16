
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int[] arr = new int[n];
            int result = 1;
            for(int i = 0; i < n; i++)
            {
                arr[input[i] - 1] = i;
            }

            int curIdx = arr[0];
            int count = 1;
            for(int i = 1; i < n; i++)
            {
                if(arr[i] > curIdx)
                {
                    count++;
                    if (count > result)
                        result = count;
                }
                else
                {
                    count = 1;
                }

                curIdx = arr[i];
            }

            Console.WriteLine(n - result);
        }
    }
}                           