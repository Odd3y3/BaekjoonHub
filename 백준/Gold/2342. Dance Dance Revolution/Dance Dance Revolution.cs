
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MAXVALUE = 500000;
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int prevInput = input[0];
            int[] prevArr = { 2, MAXVALUE, MAXVALUE, MAXVALUE, MAXVALUE };
            int[] currentArr = new int[5];
            for(int i = 1; i < input.Length - 1; i++)
            {
                if (input[i] == prevInput)              //바로 전 수와 지금 수가 같을 때
                {
                    for (int j = 0; j < 5; j++)
                        prevArr[j]++;
                }
                else
                {
                    if(Math.Abs(prevInput - input[i]) == 2) // 1, 3 일때 or 2, 4일 때   + 3
                    {
                        for (int j = 0; j < 5; j++)
                            currentArr[j] = prevArr[j] + 4;
                    }
                    else                                    // 1,2  일때 2,3 일때 3,4 일때 4,1 일때
                    {
                        for (int j = 0; j < 5; j++)
                            currentArr[j] = prevArr[j] + 3;
                    }

                    int[] tempArr = new int[5];
                    for(int j = 0; j < 5; j++)
                    {
                        if (j == 0)
                            tempArr[j] = prevArr[j] + 2;
                        else if (j == input[i])
                            tempArr[j] = prevArr[j] + 1;
                        else if (Math.Abs(j - input[i]) == 2)
                            tempArr[j] = prevArr[j] + 4;
                        else
                            tempArr[j] = prevArr[j] + 3;
                    }

                    currentArr[prevInput] = Math.Min(currentArr[prevInput], tempArr.Min());
                    currentArr[input[i]] = MAXVALUE;
                    prevArr = currentArr.ToArray();
                    prevInput = input[i];
                }
            }

            if (input.Length == 1)
                Console.WriteLine(0);
            else
                Console.WriteLine(prevArr.Min());
        }
    }
}