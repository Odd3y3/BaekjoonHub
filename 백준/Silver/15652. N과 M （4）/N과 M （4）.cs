using System;
using System.Text;

namespace MyTestingField
{
    class Program
    {
        static void Func(int start, int end, int recursive, string str, StringBuilder sb)
        {
            if(recursive == 1)
            {
                for (int i = start; i <= end; i++)
                {
                    sb.Append(str);
                    sb.AppendLine(i.ToString());
                }
            }
            else
            {
                for(int i = start; i <= end; i++)
                {
                    Func(i, end, recursive - 1, str + i + " ", sb);
                }
            }
        }
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            Func(1, n, m, string.Empty, sb);
            Console.WriteLine(sb);
        }
    }
}
