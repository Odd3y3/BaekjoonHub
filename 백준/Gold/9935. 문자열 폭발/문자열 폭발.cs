
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string bomb = Console.ReadLine();
            char[] chars = str.ToCharArray();
            
            Stack<char> stack = new Stack<char>();
            Stack<char> tempStack = new Stack<char>();

            for(int i = 0; i < str.Length; i++)
            {
                stack.Push(chars[i]);
                if(stack.Count >= bomb.Length)
                {
                    Solve(stack, bomb, tempStack);
                }
            }
            if (stack.Count == 0)
                Console.WriteLine("FRULA");
            else
                Console.WriteLine(string.Join("", stack.Reverse()));
        }
        static void Solve(Stack<char> stack, string bomb, Stack<char> tempStack)
        {
            for(int i = bomb.Length - 1; i >= 0; i--)
            {
                char c = stack.Pop();
                tempStack.Push(c);
                if(c != bomb[i])
                {
                    while(tempStack.Count > 0)
                    {
                        stack.Push(tempStack.Pop());
                    }
                    break;
                }
            }
            tempStack.Clear();
        }
    }
}