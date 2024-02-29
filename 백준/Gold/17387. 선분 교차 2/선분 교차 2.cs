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

            int ccw1 = CCW(p1, p2, p3);
            int ccw2 = CCW(p1, p2, p4);
            int ccw3 = CCW(p3, p4, p1);
            int ccw4 = CCW(p3, p4, p2);

            bool result1 = ccw1 * ccw2 <= 0;
            bool result2 = ccw3 * ccw4 <= 0;

            if (result1 && result2)
            {
                if (ccw1 == 0 && ccw2 == 0 && ccw3 == 0 && ccw4 == 0)
                {
                    long min1, max1, min2, max2;
                    if(p1.x == p2.x && p2.x == p3.x && p3.x == p4.x)
                    {
                        min1 = Math.Min(p1.y, p2.y);
                        max1 = Math.Max(p1.y, p2.y);
                        min2 = Math.Min(p3.y, p4.y);
                        max2 = Math.Max(p3.y, p4.y);
                    }
                    else
                    {
                        min1 = Math.Min(p1.x, p2.x);
                        max1 = Math.Max(p1.x, p2.x);
                        min2 = Math.Min(p3.x, p4.x);
                        max2 = Math.Max(p3.x, p4.x);
                    }

                    if (max1 >= min2 && max2 >= min1)
                        Console.WriteLine(1);
                    else
                        Console.WriteLine(0);
                }
                else
                    Console.WriteLine(1);
            }
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
            else if (c < 0)
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