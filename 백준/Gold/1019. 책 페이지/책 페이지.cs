
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(input);

            int[] result = new int[10];

            int[] tempArr = new int[10];

            for(int i = input.Length - 1; i >= 0; i--)
            {
                int num = (n / (int)Math.Pow(10, i)) % 10;
                Solve(i, num, tempArr, result);

                //마지막 수가 적용이 안되서 따로 추가
                result[num]++;
            }

            //앞자리가 0인거 제거
            for (int i = 0; i < input.Length; i++)
            {
                result[0] -= (int)Math.Pow(10, i);
            }
            

            //output
            for(int i = 0; i < 10; i++)
            {
                Console.Write(result[i]);
                Console.Write(' ');
            }
        }

        static void Solve(int idx, int num, int[] tempArr, int[] result)
        {
            if(idx != 0)
            {
                for(int i = 0; i < 10; i++)
                {
                    result[i] += (int)Math.Pow(10, idx - 1) * idx * num;
                }

            }
            for(int i = 0; i < num; i++)
            {
                result[i] += (int)Math.Pow(10, idx);
            }

            for(int i = 0; i < 10; i++)
            {
                result[i] += tempArr[i] * (int)Math.Pow(10, idx) * num;
            }
            tempArr[num]++;

        }
    }
}