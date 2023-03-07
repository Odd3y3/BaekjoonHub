
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            int n = int.Parse(Console.ReadLine());
            foreach (var item in Console.ReadLine().Split(' '))
            {
                dict.Add(item, true);
            }
            int m = int.Parse(Console.ReadLine());
            foreach (var item in Console.ReadLine().Split(' '))
            {
                if (dict.ContainsKey(item))
                    sb.Append("1 ");
                else
                    sb.Append("0 ");
            }
            Console.WriteLine(sb);
        }
    }
}