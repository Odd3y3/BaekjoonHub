using System;
using System.Collections.Generic;
using System.Text;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] answerArr = new int[n];
            for (int i = 0; i < n; i++)
                answerArr[i] = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            StringBuilder sb = new StringBuilder();

            bool no = false;

            
            int pushCount = 0;
            int arrIndex = 0;
            while (arrIndex < n)
            {
                while(pushCount < answerArr[arrIndex])
                {
                    pushCount++;
                    stack.Push(pushCount);
                    sb.AppendLine("+");
                }
                if(answerArr[arrIndex] == stack.Peek())
                {
                    arrIndex++;
                    stack.Pop();
                    sb.AppendLine("-");
                }
                else
                {
                    no = true;
                    break;
                }

            }

            if (no)
                Console.WriteLine("NO");
            else
                Console.WriteLine(sb);
        }
    }
}