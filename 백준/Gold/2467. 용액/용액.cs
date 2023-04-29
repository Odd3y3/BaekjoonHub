
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int idxStart = 0;
            int idxEnd = n - 1;
            int result = Math.Abs(arr[idxStart] + arr[idxEnd]);
            int[] resultNum = { arr[idxStart], arr[idxEnd] };
            while(idxStart != idxEnd)
            {
                int sum = arr[idxStart] + arr[idxEnd];
                int diff = Math.Abs(sum);
                if (diff < result)
                {
                    result = diff;
                    resultNum[0] = arr[idxStart];
                    resultNum[1] = arr[idxEnd];
                }

                if(sum > 0)
                    idxEnd--;
                else
                    idxStart++;
            }
            Console.WriteLine(resultNum[0] + " " + resultNum[1]);

        }
    }
}