using System;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            int w, v;
            int[] prevArr = new int[k + 1];
            int[] currArr = new int[k + 1];
            for(int i = 1; i <= n; i++)
            {
                input = Console.ReadLine().Split(' ');
                w = int.Parse(input[0]);
                v = int.Parse(input[1]);
                for(int j = 1; j <= k; j++)
                {
                    if(j < w)
                    {
                        currArr[j] = prevArr[j];
                    }
                    else
                    {
                        currArr[j] = Math.Max(prevArr[j - w] + v, prevArr[j]);
                    }
                }
                Array.Copy(currArr, prevArr, k + 1);
            }
            Console.WriteLine(currArr[k]);
        }
    }
}
