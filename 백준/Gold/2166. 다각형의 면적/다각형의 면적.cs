
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int n = int.Parse(Console.ReadLine());
            int[] arrX = new int[n];
            int[] arrY = new int[n];
            for(int i = 0; i < n; i++)
            {
                int[] inputNums = Console.ReadLine().Split().Select(int.Parse).ToArray();
                arrX[i] = inputNums[0];
                arrY[i] = inputNums[1];
            }

            //계산
            long sum = 0;
            for(int i = 0; i < n; i++)
            {
                sum += (long)arrX[i] * arrY[(i + 1) % n];
                sum -= (long)arrX[(i + 1) % n] * arrY[i];
            }
            double result = (double)Math.Abs(sum) / 2;  //절대값 후 나누기 2
            Console.WriteLine(result.ToString("0.0"));  //소수점 한자리까지 출력
        }
    }
}