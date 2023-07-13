
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n + 1];
            for(int i = 1; i <= n; ++i)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            //process
            bool[] visit = new bool[n + 1];
            List<int> answerList = new List<int>();
            for(int i = 1; i <= n; ++i)
            {
                Stack<int> tempList = new Stack<int>();
                Solve(i, arr, visit, answerList, tempList);
            }

            //output
            answerList.Sort();
            Console.WriteLine(answerList.Count);
            foreach(var item in answerList)
            {
                Console.WriteLine(item);
            }
        }
        static void Solve(int n, int[] arr, bool[] visit, List<int> answerList, Stack<int> tempList)
        {
            if (visit[n])
            {
                if (tempList.Contains(n))
                {
                    int value;
                    while((value = tempList.Pop()) != n)
                    {
                        answerList.Add(value);
                    }
                    answerList.Add(n);
                }
                else
                    return;
            }
            else
            {
                visit[n] = true;
                tempList.Push(n);
                Solve(arr[n], arr, visit, answerList, tempList);
            }
            
        }
    }
}