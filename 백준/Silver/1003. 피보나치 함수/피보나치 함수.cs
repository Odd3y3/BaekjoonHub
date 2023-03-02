
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            (int, int)[] result = new (int, int)[41];
            result[0] = (1, 0);
            result[1] = (0, 1);
            for(int i = 2; i < 41; i++)
                result[i] = (result[i - 2].Item1 + result[i - 1].Item1, result[i - 2].Item2 + result[i - 1].Item2);
            for(int i = 0; i < t; i++)
            {
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine(result[n].Item1 + " " + result[n].Item2);
            }
        }
    }
}