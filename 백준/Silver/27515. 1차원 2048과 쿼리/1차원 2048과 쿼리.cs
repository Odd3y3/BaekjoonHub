
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StringBuilder sb = new StringBuilder();
            int q = int.Parse(sr.ReadLine());
            ulong sum = 0;
            for(int i = 0; i < q; i++)
            {
                string input = sr.ReadLine();
                if (input[0] == '-')
                    sum -= ulong.Parse(input.Substring(1));
                else
                    sum += ulong.Parse(input.Substring(1));
                if (sum == 0)
                    sb.AppendLine("0");
                else
                {
                    ulong result = 1;
                    for(int j = 0; j < 63; j++)
                    {
                        if (result * 2 > sum)
                            break;
                        result *= 2;
                    }
                    sb.AppendLine(result.ToString());
                }
            }
            Console.WriteLine(sb);
        }
    }
}