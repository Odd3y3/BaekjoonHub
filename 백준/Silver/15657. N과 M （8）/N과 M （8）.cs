
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Func(int[] arr, int start, int n, int m, string str, StringBuilder sb)
        {
            if(m == 1)
            {
                for(int i = start; i < n; i++)
                {
                    sb.AppendLine(str + arr[i]);
                }
            }
            else
            {
                for(int i = start; i < n; i++)
                {
                    Func(arr, i, n, m - 1, str + arr[i] + " ", sb);
                }
            }
        }
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToArray();
            Func(arr, 0, n, m, string.Empty, sb);
            Console.WriteLine(sb);
        }
    }
}