
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int r = int.Parse(input[1]);
            int c = int.Parse(input[2]);
            int result = 0;
            int multiple = 1;
            while(r != 0 || c != 0)
            {
                result += ((r % 2) * 2 + (c % 2)) * multiple;
                r /= 2;
                c /= 2;
                multiple *= 4;
            }
            Console.WriteLine(result);
        }
    }
}