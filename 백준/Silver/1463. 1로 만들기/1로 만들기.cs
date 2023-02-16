using System;
using System.Linq;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n + 1];
            for(int i = 2; i < arr.Length; i++)
            {
                if (i % 3 == 0 && i % 2 == 0)
                    arr[i] = new int[] { arr[i / 3], arr[i / 2], arr[i - 1] }.Min() + 1;
                else if (i % 3 == 0)
                    arr[i] = Math.Min(arr[i / 3], arr[i - 1]) + 1;
                else if (i % 2 == 0)
                    arr[i] = Math.Min(arr[i / 2], arr[i - 1]) + 1;
                else
                    arr[i] = arr[i - 1] + 1;
            }
            Console.WriteLine(arr[n]);
        }
    }
}