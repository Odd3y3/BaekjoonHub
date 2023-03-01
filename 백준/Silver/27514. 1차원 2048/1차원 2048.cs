
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ulong sum = 0;
            foreach (var item in Console.ReadLine().Split(' ').Select(x=> ulong.Parse(x)))
            {
                sum += item;
            }
            
            ulong result = 1;
            for(int i = 0; i < 63; i++)
            {
                if (sum < result * 2)
                    break;
                result *= 2;
            }
            Console.WriteLine(result);
        }
    }
}