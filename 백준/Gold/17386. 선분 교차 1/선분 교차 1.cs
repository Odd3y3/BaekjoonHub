
namespace TestingField
{
    internal class Program
    {
        struct Vec
        {
            public long x;
            public long y;
            public Vec(long x, long y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Vec p1 = new Vec(input[0], input[1]);
            Vec p2 = new Vec(input[2], input[3]);
            input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Vec p3 = new Vec(input[0], input[1]);
            Vec p4 = new Vec(input[2], input[3]);

            bool result1 = CCW(p1, p2, p3) * CCW(p1, p2, p4) <= 0;
            bool result2 = CCW(p3, p4, p1) * CCW(p3, p4, p2) <= 0;

            if (result1 && result2)
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }

        static int CCW(Vec p1, Vec p2, Vec p3)
        {
            Vec v1 = new Vec(p2.x - p1.x, p2.y - p1.y);
            Vec v2 = new Vec(p3.x - p1.x, p3.y - p1.y);
            long c = Cross(v1, v2);
            if (c > 0)
                return 1;
            else if(c < 0)
                return -1;
            else
                return 0;
        }

        static long Cross(Vec v1, Vec v2)
        {
            return v1.x * v2.y - v2.x * v1.y;
        }
    }
}