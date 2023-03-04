
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] Xs = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            var arr = Xs.Distinct().OrderBy(x => x);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            int count = 0;
            foreach (var item in arr)
            {
                dict.Add(item, count);
                count++;
            }
            Console.WriteLine(string.Join(' ', Xs.Select(x => dict[x])));
        }
    }
}