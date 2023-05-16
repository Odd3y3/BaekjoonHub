
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> dpList = new List<int>(n + 1);
            dpList.Add(0);
            for(int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                for(int j = 0; j < dpList.Count; j++)
                {
                    if(dpList[j] > num)
                    {
                        dpList[j] = num;
                        break;
                    }
                }
                if (dpList[dpList.Count - 1] < num)
                    dpList.Add(num);
            }
            Console.WriteLine(n - dpList.Count + 1);
        }
    }
}

