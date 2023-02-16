using System;
using System.Linq;

namespace MyTestingField
{
    class Program
    {
        static void RecFunc(int length, int num, bool[] buttons, int n, ref int minValue)
        {
            if(length == 0)
            {
                minValue = Math.Min(Math.Abs(num - n) + num.ToString().Length , minValue);
            }
            else
            {
                for(int i = 0; i < 10; i++)
                {
                    if (buttons[i])
                        RecFunc(length - 1, num * 10 + i, buttons, n, ref minValue);
                }
            }
            
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int minValue = Math.Abs(n - 100);

            bool[] buttons = Enumerable.Repeat(true, 10).ToArray();
            if(m != 0)
            {
                foreach(int item in Console.ReadLine().Split(' ').Select(x => int.Parse(x)))
                {
                    buttons[item] = false;
                }
            }
            for(int i = 1; i <= 6; i++)
                RecFunc(i, 0, buttons, n, ref minValue);
            Console.WriteLine(minValue);
        }
    }
}