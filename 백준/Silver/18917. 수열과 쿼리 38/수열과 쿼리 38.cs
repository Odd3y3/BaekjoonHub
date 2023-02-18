using System;
using System.Text;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            long sum = 0;
            long xor = 0;
            long x = 0;
            string[] input;
            for (int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split(' ');
                switch(input[0])
                {
                    case "1":
                        x = long.Parse(input[1]);
                        sum += x;
                        xor ^= x;
                        break;
                    case "2":
                        x = long.Parse(input[1]);
                        sum -= x;
                        xor ^= x;
                        break;
                    case "3":
                        sb.AppendLine(sum.ToString());
                        break;
                    case "4":
                        sb.AppendLine(xor.ToString());
                        break;
                }
            }
            Console.WriteLine(sb);
        }
    }
}