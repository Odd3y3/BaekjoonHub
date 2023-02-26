using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int initPointX = int.Parse(input[0]);
            int initPointY = int.Parse(input[1]);
            int n = int.Parse(Console.ReadLine());
            int x, y;
            Dictionary<decimal, int> targets = new Dictionary<decimal, int>();

            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                x = int.Parse(input[0]) - initPointX;
                y = int.Parse(input[1]) - initPointY;
                if(y < 0 && x != 0)
                {
                    if(x > 0)
                    {
                        decimal temp = ((decimal)y / x) / x;
                        if (!targets.ContainsKey(temp))
                            targets.Add(temp, 1);
                        else
                            targets[temp]++;
                    }
                    else
                    {
                        decimal temp = (((decimal)y / x) / x) * (-1);
                        if (!targets.ContainsKey(temp))
                            targets.Add(temp, 1);
                        else
                            targets[temp]++;
                    }
                }
            }
            if (targets.Count > 0)
                Console.WriteLine(targets.Values.Max());
            else
                Console.WriteLine(0);
        }
    }
}
