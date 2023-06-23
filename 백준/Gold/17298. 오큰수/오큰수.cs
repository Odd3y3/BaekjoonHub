
namespace TestField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] answer = new int[n];
            Stack<(int, int)> stack = new Stack<(int, int)> ();
            for(int i = 0; i < n; i++)
            {
                while(stack.Count > 0)
                {
                    int index, value;
                    (index, value) = stack.Peek();
                    if (input[i] > value)
                    {
                        stack.Pop();
                        answer[index] = input[i];
                    }   
                    else
                        break;
                }
                stack.Push((i, input[i]));
            }

            for(int i = 0; i < n; i++)
            {
                if (answer[i] == 0)
                    answer[i] = -1;
            }

            Console.WriteLine(string.Join(" ", answer));
        }
    }
}