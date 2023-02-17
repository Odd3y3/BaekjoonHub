using System;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num2 = 0;
            int num5 = 0;
            for (int i = 2; i <= n; i++)
            {
                int temp = i;
                while(temp % 2 == 0)
                {
                    num2++;
                    temp /= 2;
                }
                while(temp % 5 == 0)
                {
                    num5++;
                    temp /= 5;
                }
            }
            Console.WriteLine(Math.Min(num2, num5));
        }
    }
}