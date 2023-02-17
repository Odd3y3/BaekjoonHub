using System;
using System.Text;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            bool[] s = new bool[21];
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < m; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int n = 0;
                if(input.Length > 1)
                    n = int.Parse(input[1]);
                switch(input[0])
                {
                    case "add":
                        s[n] = true;
                        break;
                    case "remove":
                        s[n] = false;
                        break;
                    case "check":
                        if (s[n]) sb.AppendLine("1");
                        else sb.AppendLine("0");
                        break;
                    case "toggle":
                        if (s[n]) s[n] = false;
                        else s[n] = true;
                        break;
                    case "all":
                        for(int j = 1; j <= 20; j++)
                            s[j] = true;
                        break;
                    case "empty":
                        for (int j = 1; j <= 20; j++)
                            s[j] = false;
                        break;

                }
            }
            Console.WriteLine(sb);
        }
    }
}