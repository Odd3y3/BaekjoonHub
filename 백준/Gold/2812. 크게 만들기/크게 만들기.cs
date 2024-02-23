
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);
            
            int[] arr = Console.ReadLine().ToCharArray().Select(x => x - '0').ToArray();
            Stack<int> stack = new Stack<int>();

            for(int i = 0; i < n; ++i)
            {
                while(stack.Count > 0 && k > 0 && stack.Peek() < arr[i])
                {
                    stack.Pop();
                    k--;
                }
                stack.Push(arr[i]);
            }

            if(k > 0)
            {
                for (int i = 0; i < k; ++i)
                    stack.Pop();
            }


            //output
            StringBuilder sb = new StringBuilder();
            foreach (var item in stack.Reverse())
            {
                sb.Append(item);
            }
            Console.WriteLine(sb);
        }
    }
}