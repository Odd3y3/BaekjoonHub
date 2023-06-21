using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestField
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[] arr = Console.ReadLine().Split().Select(long.Parse).OrderBy(x => x).ToArray();
            long diff = 3000000000;
            long[] answer = new long[3];
            for(int i = 0; i < n - 2; i++)
            {
                int start = i + 1;
                int end = n - 1;
                while (start != end)
                {
                    long sum = arr[i] + arr[start] + arr[end];
                    
                    if(Math.Abs(sum) < diff)
                    {
                        answer[0] = arr[i];
                        answer[1] = arr[start];
                        answer[2] = arr[end];
                        diff = Math.Abs(sum);
                    }


                    if(sum < 0)
                    {
                        start++;
                    }
                    else
                    {
                        end--;
                    }

                }

            }
            Console.WriteLine(string.Join(" ", answer));
        }
    }
}
