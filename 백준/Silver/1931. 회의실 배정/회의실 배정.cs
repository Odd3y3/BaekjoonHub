
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] input;
            (long, long)[] arr = new (long, long)[n];
            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                arr[i] = (long.Parse(input[0]), long.Parse(input[1]));
            }
            long minValue = 0;
            int count = 0;
            foreach(var time in arr.OrderBy(x => x.Item1).OrderBy(x => x.Item2))
            {
                if(time.Item1 >= minValue)
                {
                    minValue = time.Item2;
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}