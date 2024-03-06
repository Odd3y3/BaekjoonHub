
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).OrderBy(x => x).ToArray();

            int result = 0;
            foreach (int item in arr)
            {
                if (item > result + 1) break;

                result += item;
            }

            Console.WriteLine(result + 1);
        }
    }
}