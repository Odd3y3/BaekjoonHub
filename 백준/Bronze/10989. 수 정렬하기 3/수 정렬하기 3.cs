using System;
using System.IO;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            int n = int.Parse(sr.ReadLine());
            int[] count = new int[10001];
            for (int i = 0; i < n; i++)
                count[int.Parse(sr.ReadLine())]++;
            for (int i = 1; i <= 10000; i++)
            {
                for (int j = 0; j < count[i]; j++)
                    sw.WriteLine(i.ToString());
            }
            sr.Close();
            sw.Close();
        }
    }
}
