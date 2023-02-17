using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            string s;
            int temp;
            string[] doGam = new string[n + 1];
            Dictionary<string, int> doGamDict = new Dictionary<string, int>();
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i < n + 1; i++)
            {
                doGam[i] = Console.ReadLine();
                doGamDict[doGam[i]] = i;
            }
            for(int i = 0; i < m; i++)
            {
                s = Console.ReadLine();
                if (int.TryParse(s, out temp))
                    sb.AppendLine(doGam[temp]);
                else
                    sb.AppendLine(doGamDict[s].ToString());
            }
            Console.WriteLine(sb);
        }
    }
}