
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int m = int.Parse(input[0]);
            int n = int.Parse(input[1]);
            int[,] inputArr = new int[m, n];
            int[,] dpArr = new int[m, n];
            //init dpArr ( -1 로 초기화, -1은 아직 진행하지 않은 노드 )
            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    dpArr[i, j] = -1;

            //input
            for (int i = 0; i < m; i++)
            {
                int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for(int j = 0; j < n; j++)
                {
                    inputArr[i, j] = temp[j];
                }
            }

            Console.WriteLine(DP(0, 0, dpArr, inputArr));
        }

        static int DP(int x, int y, int[,] dpArr, int[,] inputArr)
        {
            int lengthX = dpArr.GetLength(0);
            int lengthY = dpArr.GetLength(1);
            if (x == lengthX - 1 && y == lengthY - 1)   //마지막에 도착한 경우
                return 1;
            else if (dpArr[x, y] != -1)                   //노드가 이미 방문 된 경우 (값이 있는 경우)
                return dpArr[x, y];
            else                                        //노드가 아직 진행되지 않은 경우 ( 값을 모르는 경우 )
            {
                int sum = 0;
                if (x > 0 && inputArr[x, y] > inputArr[x - 1, y])
                    sum += DP(x - 1, y, dpArr, inputArr);
                if (x < lengthX - 1 && inputArr[x, y] > inputArr[x + 1, y])
                    sum += DP(x + 1, y, dpArr, inputArr);

                if (y > 0 && inputArr[x, y] > inputArr[x, y - 1])
                    sum += DP(x, y - 1, dpArr, inputArr);
                if (y < lengthY - 1 && inputArr[x, y] > inputArr[x, y + 1])
                    sum += DP(x, y + 1, dpArr, inputArr);

                dpArr[x, y] = sum;
                return sum;
            }
        }
    }
}

