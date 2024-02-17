
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            int n = int.Parse(inputs[0]);
            int l = int.Parse(inputs[1]);
            int[,] map = new int[n, n];
            //input
            for(int i = 0; i < n; ++i)
            {
                int j = 0;
                foreach (int item in Console.ReadLine().Split().Select(x => int.Parse(x)))
                {
                    map[i, j] = item;
                    ++j;
                }
            }

            int result = 0;
            int[] tempList = new int[n];
            //가로 길
            for(int i = 0; i < n; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    tempList[j] = map[i, j];
                }

                if (Solve(tempList, l))
                    ++result;
            }
            //세로 길
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    tempList[j] = map[j, i];
                }

                if (Solve(tempList, l))
                    ++result;
            }

            Console.WriteLine(result);
        }

        static bool Solve(int[] list, int l)
        {
            int prevNum = list[0];
            int prevSameNumCount = 1;   //앞쪽에 같은 숫자 갯수
            int nextSameNumCount = 0;   //뒤쪽에 몇개의 같은 숫자 개수가 잇어야대는지?
            
            for(int i = 1; i < list.Length; ++i)
            {
                int curNum = list[i];
                if(curNum == prevNum)
                {
                    if (nextSameNumCount > 0)
                        --nextSameNumCount;
                    else
                        ++prevSameNumCount;
                }
                else if(curNum == prevNum + 1)
                {
                    if (prevSameNumCount < l)
                        return false;
                    
                    prevSameNumCount = 1;

                    prevNum = curNum;
                }
                else if(curNum == prevNum - 1)
                {
                    if (nextSameNumCount > 0)
                        return false;
                    nextSameNumCount = l - 1;
                    prevSameNumCount = 0;
                    prevNum = curNum;
                }
                else
                {
                    return false;
                }
            }

            if (nextSameNumCount > 0)
                return false;

            return true;
        }
    }
}