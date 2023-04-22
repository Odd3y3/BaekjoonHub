
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arr = new int[1000001];
            int length = 1;
            arr[0] = input[0];
            for (int i = 1; i < n; i++)
            {
                if (input[i] > arr[length - 1])
                {
                    arr[length] = input[i];
                    length++;
                }
                else
                {
                    Func(input[i], arr, 0, length - 1);
                }
            }
            Console.WriteLine(length);
        }
        static void Func(int input, int[] arr, int start, int end)
        {
            int middle = (start + end) / 2;
            if(end - start <= 1)
            {
                if (arr[start] >= input)
                {
                    arr[start] = input;
                }
                else if (arr[start] < input && arr[end] >= input)
                {
                    arr[end] = input;
                }
                else
                {
                    arr[end + 1] = input;
                }
            }
            else if(arr[middle] >= input)
            {
                Func(input, arr, start, middle - 1);
            }
            else
            {
                Func(input, arr, middle + 1, end);
            }
        }
    }
}