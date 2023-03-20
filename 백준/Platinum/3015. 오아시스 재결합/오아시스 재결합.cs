
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<(long, int)> stack = new Stack<(long, int)>(); //item1 = 사람의 키, item2 = (같은 키의)사람 수
            //stack.Push((int.Parse(Console.ReadLine()), 1));
            long num;
            long result = 0;
            for(int i = 0; i < n; i++)
            {
                num = long.Parse(Console.ReadLine());
                if(stack.Count == 0)
                {
                    stack.Push((num, 1));
                    continue;
                }

                if (stack.Peek().Item1 < num)
                {
                    //스택에 있는거 pop하면서 작은거 없앤 수 만큼 result ++
                    while(stack.Count > 0 && stack.Peek().Item1 < num)
                    {
                        (long, int) temp = stack.Pop();
                        result += temp.Item2;
                    }
                    if (stack.Count > 0 && stack.Peek().Item1 == num)
                    {
                        (long, int) temp = stack.Pop();
                        result += temp.Item2;
                        if (stack.Count > 0) result++;
                        stack.Push((temp.Item1, temp.Item2 + 1));
                    }
                    else
                    {
                        if (stack.Count > 0) result++;
                        stack.Push((num, 1));
                    }
                }
                else if(stack.Peek().Item1 == num)
                {
                    (long, int) temp = stack.Pop();
                    result += stack.Count == 0 ? temp.Item2 : temp.Item2 + 1;
                    stack.Push((temp.Item1, temp.Item2 + 1));
                }
                else
                {
                    stack.Push((num, 1));
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}