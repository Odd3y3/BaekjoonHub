using System;
using System.Linq;
using System.Text;

namespace MyTestingField
{
    class Program
    {
        static bool AC(string  p, int n, ref int[] arr)
        {
            int startIndex = 0;
            int endIndex = n - 1;
            bool reverse = false;
            foreach (char item in p)
            {
                if (item == 'R')
                {
                    if (reverse) reverse = false;
                    else reverse = true;
                }
                else if (item == 'D')
                {
                    if (reverse)
                    {
                        endIndex--;
                        n--;
                    }
                    else
                    {
                        startIndex++;
                        n--;
                    }
                }
                else
                    return false;
            }
            if (n < 0)
                return false;
            else
            {
                int[] returnArr = new int[n];
                if (reverse)
                {
                    for(int i = 0; i < n; i++)
                    {
                        returnArr[i] = arr[endIndex - i];
                    }
                }
                else
                {
                    for(int i = 0; i < n; i++)
                    {
                        returnArr[i] = arr[startIndex + i];
                    }
                }
                arr = returnArr;
                return true;
            }
        }
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            
            for(int i = 0; i < t; i++)
            {
                string p = Console.ReadLine();
                int n = int.Parse(Console.ReadLine());
                string strArr = Console.ReadLine();
                int[] arr;
                if (n == 0)
                    arr = new int[0];
                else
                    arr = strArr.Substring(1, strArr.Length - 2).Split(',').Select(x => int.Parse(x)).ToArray();
                if (AC(p, n, ref arr))
                {
                    sb.Append("[");
                    sb.Append(string.Join(",", arr));
                    sb.AppendLine("]");
                }
                else
                    sb.AppendLine("error");
            }
            Console.WriteLine(sb);
        }
    }
}