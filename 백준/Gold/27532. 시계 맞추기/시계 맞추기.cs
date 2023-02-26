using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputTimes = new int[n];
            int result = n;
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(':');
                int hour = int.Parse(input[0]);
                int min = int.Parse(input[1]);
                inputTimes[i] = (hour * 60 + min) % 720;
            }
            for (int R = 0; R < 720; R++)
            {
                List<int> times = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    int temp = inputTimes[i] - (R * i);
                    while (temp < 0)
                        temp += 720;
                    times.Add(temp % 720);
                }
                times = times.Distinct().ToList();
                result = Math.Min(result, times.Count);
            }
            Console.WriteLine(result);

        }
    }
}
