
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            Queue<char> queue = new Queue<char>();
            Stack<char> stack = new Stack<char>();
            int count = str2.Length;
            foreach (char c in str2)
            {
                queue.Enqueue(c);
                stack.Push(c);
            }

            //process
            bool isReverse = false;
            for(int i = 0; i < str2.Length - str1.Length; i++)
            {
                if(!isReverse)
                {
                    char c = stack.Pop();
                    if (c == 'B')
                    {
                        isReverse = !isReverse;
                    }
                }
                else
                {
                    char c = queue.Dequeue();
                    if(c == 'B')
                    {
                        isReverse = !isReverse;
                    }
                }
            }

            char[] answer = new char[str1.Length];
            if(isReverse)
            {
                for(int i = 0; i < str1.Length; i++)
                {
                    answer[i] = stack.Pop();
                }
            }
            else
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    answer[i] = queue.Dequeue();
                }
            }

            if (string.Join("", answer) == str1)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }
    }
}