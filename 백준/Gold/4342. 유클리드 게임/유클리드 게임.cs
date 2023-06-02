
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while((input = Console.ReadLine()) != "0 0")
            {
                string[] inputs = input.Split();
                long num1 = long.Parse(inputs[0]);
                long num2 = long.Parse(inputs[1]);
                long max = Math.Max(num1, num2);
                long min = Math.Min(num1, num2);
                if (Solve(max, min, true))
                    Console.WriteLine("A wins");
                else
                    Console.WriteLine("B wins");
            }
        }
        static bool Solve(long bigNum, long smallNum, bool firstPersonWin)
        {
            if (bigNum % smallNum == 0)
                return firstPersonWin;
            else if(bigNum > smallNum * 2)
            {
                long temp = (bigNum % smallNum) + smallNum;
                if (Solve(temp, smallNum, !firstPersonWin) == !firstPersonWin && Solve(smallNum, bigNum % smallNum, !firstPersonWin) == !firstPersonWin)
                    return !firstPersonWin;
                else
                    return firstPersonWin;
            }
            else
            {
                return Solve(smallNum, bigNum % smallNum, !firstPersonWin);
            }
        }
    }
}

