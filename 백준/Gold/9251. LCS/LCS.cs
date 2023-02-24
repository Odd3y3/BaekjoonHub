using System;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int length1 = input1.Length;
            int length2 = input2.Length;
            int[,] resultArr = new int[length1 + 1, length2 + 1];
            for(int i = 1; i <= length1; i++)
            {
                for(int j = 1; j <= length2; j++)
                {
                    if (input1[i - 1] == input2[j - 1])
                        resultArr[i, j] = resultArr[i - 1, j - 1] + 1;
                    else
                        resultArr[i, j] = Math.Max(resultArr[i, j - 1], resultArr[i - 1, j]);
                }
            }
            Console.WriteLine(resultArr[length1, length2]);
        }
    }
}
