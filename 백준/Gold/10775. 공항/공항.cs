
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int g = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int[] union = new int[g + 1];
            for (int i = 0; i < union.Length; i++)
                union[i] = -1;

            int[] input = new int[p];
            for (int i = 0; i < p; i++)
                input[i] = int.Parse(Console.ReadLine());

            int result = 0;
            for(int i = 0; i < p; i++)
            {
                if (Func(input[i], union) != -1)
                    result++;
                else
                    break;
            }
            Console.WriteLine(result);
        }

        static int Func(int i, int[] union)
        {
            if (i == 0)
                return -1;
            else if (union[i] == -1)
            {
                union[i] = i - 1;
                return i - 1;
            }
            else
            {
                int value = Func(union[i], union);
                union[i] = value;
                return value;
            }
        }
    }
}