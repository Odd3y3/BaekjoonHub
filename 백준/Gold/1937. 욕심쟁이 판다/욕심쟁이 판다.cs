
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] map = new int[n, n];
            for(int i = 0; i < n; ++i)
            {
                int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                for(int j = 0; j < n; ++j)
                {
                    map[i, j] = input[j];
                }
            }

            //process
            int[,] resultList = new int[n, n];
            int result = 0;
            for(int i = 0; i < n; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    int value = RecursiveFunc(i, j, n, map, resultList);
                    if (value > result)
                        result = value;
                }
            }
            Console.WriteLine(result);
        }

        static int RecursiveFunc(int x, int y, int n, int[,] map, int[,] resultList)
        {
            if (resultList[x, y] != 0)
                return resultList[x, y];
            
            int result = 1;
            int tempValue = 0;
            if(x > 0 && map[x, y] < map[x - 1, y])
            {
                tempValue = RecursiveFunc(x - 1, y, n, map, resultList) + 1;
                if(tempValue > result)
                    result = tempValue;
            }
            if(y > 0 && map[x, y] < map[x, y - 1])
            {
                tempValue = RecursiveFunc(x, y - 1, n, map, resultList) + 1;
                if(tempValue > result)
                    result = tempValue;
            }
            if (x < n - 1 && map[x, y] < map[x + 1, y])
            {
                tempValue = RecursiveFunc(x + 1, y, n, map, resultList) + 1;
                if (tempValue > result)
                    result = tempValue;
            }
            if (y < n - 1 && map[x, y] < map[x, y + 1])
            {
                tempValue = RecursiveFunc(x, y + 1, n, map, resultList) + 1;
                if (tempValue > result)
                    result = tempValue;
            }

            resultList[x, y] = result;

            return result;
        }
    }
}