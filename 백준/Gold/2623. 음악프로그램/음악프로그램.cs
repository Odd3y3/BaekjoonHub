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
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int m = int.Parse(input[1]);
            int[] arr = new int[n + 1];
            List<int>[] graph = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
                graph[i] = new List<int>();
            Stack<int> stack = new Stack<int>();
            List<int> answer = new List<int>();

            //input
            for(int i = 0; i < m; i++)
            {
                int[] inputNum = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j = 1; j < inputNum[0]; j++)
                {
                    graph[inputNum[j]].Add(inputNum[j + 1]);
                    arr[inputNum[j + 1]]++;
                }
            }

            //위상 정렬
            for(int i = 1; i <= n; i++)
            {
                if (arr[i] == 0)
                    stack.Push(i);
            }
            while(stack.Count > 0)
            {
                int value = stack.Pop();
                answer.Add(value);
                foreach (var item in graph[value])
                {
                    arr[item]--;
                    if (arr[item] == 0)
                        stack.Push(item);
                }
            }

            //output
            if (answer.Count == n)
            {
                foreach (var item in answer)
                    Console.WriteLine(item);
            }
            else
                Console.WriteLine(0);
        }
    }
}
