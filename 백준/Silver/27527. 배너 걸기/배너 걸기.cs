using System;
using System.Linq;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[] arr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            int[] count = new int[1000001];
            float condition = (float)(9 * m) / 10;
            bool result = false;
            for(int i = 0; i < n; i++)
            {
                count[arr[i]]++;
                if (i >= m)
                    count[arr[i - m]]--;
                if (count[arr[i]] >= condition)
                {
                    result = true;
                    break;
                }
            }
            if (result)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
