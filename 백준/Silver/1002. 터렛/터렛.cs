
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int test =  0; test < t; ++test)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int x1 = input[0];
                int y1 = input[1];
                int r1 = input[2];
                int x2 = input[3];
                int y2 = input[4];
                int r2 = input[5];

                //최대 2억
                int dist = (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);

                if (x1 == x2 && y1 == y2)
                {
                    if (r1 == r2)
                        Console.WriteLine(-1);
                    else
                        Console.WriteLine(0);
                }
                else if (dist == (r1 + r2) * (r1 + r2) || dist == (r1 - r2) * (r1 - r2))
                    Console.WriteLine(1);
                else if (dist < (r1 + r2) * (r1 + r2) && dist > (r1 - r2) * (r1 - r2))
                    Console.WriteLine(2);
                else
                    Console.WriteLine(0);

            }
        }
    }
}