using System;
using System.Text;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int x1, y1, x2, y2;
            int[,] table = new int[n + 1, n + 1];
            int[,] sumTable = new int[n + 1, n + 1];
            //table 입력 받기, 초기화
            for (int i = 1; i <= n; i++)
            {
                input = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                    table[i, j + 1] = int.Parse(input[j]);
            }
            //sumTable 계산
            for (int i = 1; i <= n; i++)
            {
                for(int j = 1; j <= n; j++)
                {
                    sumTable[i, j] = sumTable[i - 1, j] + sumTable[i, j - 1] - sumTable[i - 1, j - 1] + table[i, j];
                }
            }
            //두 점 입력 받고, 출력
            for(int i = 0; i < m; i++)
            {
                input = Console.ReadLine().Split(' ');
                x1 = int.Parse(input[0]);
                y1 = int.Parse(input[1]);
                x2 = int.Parse(input[2]);
                y2 = int.Parse(input[3]);
                int result = sumTable[x2, y2] - sumTable[x1 - 1, y2] - sumTable[x2, y1 - 1] + sumTable[x1 - 1, y1 - 1];
                sb.AppendLine(result.ToString());
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
