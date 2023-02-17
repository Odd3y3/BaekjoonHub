using System;
using System.Collections.Generic;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            string s;
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int count = 0;
            Dictionary<string, bool> dict = new Dictionary<string, bool>();
            List<string> result = new List<string>();
            for(int i = 0; i < n; i++)
            {
                dict[Console.ReadLine()] = true;
            }
            for(int i = 0; i < m; i++)
            {
                s = Console.ReadLine();
                if (dict.ContainsKey(s))
                {
                    count++;
                    result.Add(s);
                }
            }
            result.Sort();
            Console.WriteLine(count);
            foreach (string item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}