
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int[] result = new int[14];
            result[1] = 1;
            result[2] = 1;
            result[3] = 1;
            for(int i = 1; i < 11; i++)
            {
                result[i + 1] += result[i];
                result[i + 2] += result[i];
                result[i + 3] += result[i];
            }

            for(int i = 0; i < t; i++)
            {
                Console.WriteLine(result[int.Parse(Console.ReadLine())]);
            }
        }
    }
}