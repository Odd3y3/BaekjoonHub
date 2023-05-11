
using System.Numerics;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int result = 0;
            int[] arr = new int[n];
            Func(0, n, arr, ref result); 
            Console.WriteLine(result);  
        }

        static void Func(int index, int n, int[] arr, ref int result)
        {
            if(index == n)
            {
                result++;
                return;
            }
            for(int i = 0; i < n; i++)
            {
                if(CanPlaceQueen(index, i, arr))
                {
                    arr[index] = i;
                    Func(index + 1, n, arr, ref result);
                }
            }
        }
        static bool CanPlaceQueen(int index, int num, int[] arr)
        {
            for(int i = 0; i < index; i++)
            {
                if (arr[i] - i == num - index || arr[i] + i == index + num || arr[i] == num)
                    return false;
            }

            return true;
        }
    }
}