using System;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);

            //map 입력 & 초기화
            int[,] map = new int[n, m];
            for(int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(' ');
                for(int j = 0; j < m; j++)
                {
                    map[i, j] = int.Parse(input[j]);
                }
            }

            int[,] sumResult = new int[n, m];
            //sumResult 첫 줄 초기화
            sumResult[0, 0] = map[0, 0];
            for (int i = 1; i < m; i++)
                sumResult[0, i] = sumResult[0, i - 1] + map[0, i];
            //process
            for(int i = 1; i < n; i++)
            {
                int[] leftToRight = new int[m];
                leftToRight[0] = sumResult[i - 1, 0] + map[i, 0];
                for(int j = 1; j < m; j++)
                {
                    leftToRight[j] = Math.Max(leftToRight[j - 1], sumResult[i - 1, j]) + map[i, j];
                }

                int[] rightToLeft = new int[m];
                rightToLeft[m - 1] = sumResult[i - 1, m - 1] + map[i, m - 1];
                for(int j = m - 2; j >= 0; j--)
                {
                    rightToLeft[j] = Math.Max(rightToLeft[j + 1], sumResult[i - 1, j]) + map[i, j];
                }
                
                for(int j = 0; j < m; j++)
                {
                    sumResult[i, j] = Math.Max(leftToRight[j], rightToLeft[j]);
                }
            }
            Console.WriteLine(sumResult[n - 1, m - 1]);
            
        }
    }
}
