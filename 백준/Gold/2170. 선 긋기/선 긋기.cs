
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            (int, int)[] arr = new (int, int)[n];
            for(int i = 0; i < n; ++i)
            {
                string[] input = Console.ReadLine().Split();
                int a = int.Parse(input[0]);
                int b = int.Parse(input[1]);
                arr[i] = (a, b);
            }
            arr = arr.OrderBy(x => x.Item1).ToArray();

            //process
            int start = int.MinValue;
            int end = int.MinValue;
            int value = 0;
            for(int i = 0; i <= n; ++i)
            {
                if (i == n)
                {
                    value += end - start;
                }
                else if (arr[i].Item1 > end)
                {
                    value += end - start;
                    start = arr[i].Item1;
                    end = arr[i].Item2;
                }
                else
                {
                    end = Math.Max(arr[i].Item2, end);
                }
            }
            Console.WriteLine(value);
        }
    }
}