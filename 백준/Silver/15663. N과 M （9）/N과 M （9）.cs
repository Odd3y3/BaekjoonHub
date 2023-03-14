
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            var list = Console.ReadLine().Split(' ').Select(int.Parse).OrderBy(x => x).ToList();
            Func(list, m, string.Empty, sb);
            Console.WriteLine(sb);
        }
        static void Func(List<int> list, int m, string str, StringBuilder sb)
        {
            var newList = list.Distinct().ToList();
            if(m == 1)
            {
                foreach (var item in newList)
                {
                    sb.AppendLine(str + item);
                }
            }
            else
            {
                foreach (var item in newList)
                {
                    var tempList = new List<int>(list);
                    tempList.Remove(item);
                    Func(tempList, m - 1, str + item + " ", sb);
                }
            }
        }
    }
    
}