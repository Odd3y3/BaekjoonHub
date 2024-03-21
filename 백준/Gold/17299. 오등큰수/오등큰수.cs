
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Dictionary<int, int> numCount = new Dictionary<int, int>();
            foreach (int item in arr)
            {
                if (!numCount.ContainsKey(item))
                    numCount.Add(item, 0);
                numCount[item]++;
            }


            Stack<int> stack = new Stack<int>();
            Stack<int> result = new Stack<int>();
            for(int i = n - 1; i >= 0; i--)
            {
                int value = -1;
                while (stack.Count > 0)
                {
                    if(numCount[stack.Peek()] <= numCount[arr[i]])
                    {
                        stack.Pop();
                    }
                    else
                    {
                        value = stack.Peek();
                        break;
                    }
                }
                stack.Push(arr[i]);

                result.Push(value);
            }

            //output
            StringBuilder sb = new StringBuilder();
            foreach (int item in result)
            {
                sb.Append(item);
                sb.Append(' ');
            }
            Console.WriteLine(sb);
        }
    }
}