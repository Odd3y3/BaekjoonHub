
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] buildTime = new int[n + 1];
            List<int>[] buildFirstList = new List<int>[n + 1];
            for (int i = 1; i <= n; i++)
                buildFirstList[i] = new List<int>();
            
            //input
            for(int i = 0; i < n; i++)
            {
                int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                buildTime[i + 1] = input[0];
                int index = 1;
                while (input[index] != -1)
                {
                    buildFirstList[i + 1].Add(input[index]);
                    index++;
                }
            }

            //progress
            int[] answer = new int[n + 1];
            for(int i = 1; i <= n; i++)
            {
                Solve(i, answer, buildTime, buildFirstList);
            }

            //output
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(answer[i]);
            }
        }

        static int Solve(int i, int[] answer, int[] buildTime, List<int>[] buildFirstList)
        {
            if (answer[i] != 0)
                return answer[i];

            if (buildFirstList[i].Count == 0)
            {
                answer[i] = buildTime[i];
                return answer[i];
            }
            else
            {
                int max = 0;
                foreach (int item in buildFirstList[i])
                {
                    max = Math.Max(max, Solve(item, answer, buildTime, buildFirstList));
                }
                answer[i] = buildTime[i] + max;
                return answer[i];
            }
        }
    }
}