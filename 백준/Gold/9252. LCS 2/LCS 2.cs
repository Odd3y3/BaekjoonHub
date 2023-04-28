
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();
            int length1 = input1.Length;
            int length2 = input2.Length;
            int[,] arr = new int[length1 + 1, length2 + 1];
            for(int i = 1; i <= length1; i++)
            {
                for(int j = 1; j <= length2; j++)
                {
                    if (input1[i - 1] == input2[j - 1])
                    {
                        arr[i, j] = arr[i - 1, j - 1] + 1;
                    }
                    else
                    {
                        arr[i, j] = Math.Max(arr[i, j - 1], arr[i - 1, j]);
                    }
                }
            }
            int result = arr[length1, length2];
            Console.WriteLine(result);

            //뒤로 가면서 LCS 구하기
            int indexX = length1;
            int indexY = length2;
            int value = result;
            
            List<char> lcs = new List<char>();
            while(value > 0)
            {
                int currentValue = arr[indexX, indexY];
                if (arr[indexX - 1, indexY] == currentValue)
                {
                    indexX--;
                }
                else if (arr[indexX, indexY - 1] == currentValue)
                {
                    indexY--;
                }
                else
                {
                    lcs.Add(input1[indexX - 1]);
                    indexX--;
                    indexY--;
                    value--;
                }
            }
            //LCS 출력
            for(int i = result - 1; i >= 0; i--)
            {
                Console.Write(lcs[i]);
            }
        }
    }
}