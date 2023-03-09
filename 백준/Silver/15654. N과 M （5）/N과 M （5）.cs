
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Func(int n, List<int> nums, string str, StringBuilder sb)
        {
            if(n == 1)
            {
                foreach (int item in nums)
                {
                    sb.AppendLine(str + item);
                }
            }
            else
            {
                for(int i = 0; i < nums.Count; i++)
                {
                    List<int> newList = new List<int>(nums);
                    newList.RemoveAt(i);
                    Func(n - 1, newList, str + nums[i] + " ", sb);
                }
            }
        }
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split(' ');
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            List<int> nums = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).OrderBy(x => x).ToList();


            Func(n, nums, string.Empty, sb);
            Console.WriteLine(sb); 
        }
    }
}