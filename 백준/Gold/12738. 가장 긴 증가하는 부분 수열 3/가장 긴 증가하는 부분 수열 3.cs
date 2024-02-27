
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            List<int> list = new List<int>();
            list.Add(nums[0]);

            for(int i = 1; i < n; ++i)
            {
                if (nums[i] > list[list.Count - 1])
                    list.Add(nums[i]);
                else
                    list[Recursive(nums[i], 0, list.Count - 1, list)] = nums[i];
            }

            Console.WriteLine(list.Count);
        }
        static int Recursive(int n, int start, int end, List<int> list)
        {
            if (start == end)
                return start;
            else
            {
                int i = (start + end) / 2;
                if (list[i] == n)
                    return i;
                else if (list[i] > n)
                    return Recursive(n, start, i, list);
                else
                    return Recursive(n, i + 1, end, list);
            }
        }
    }
}