
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[] arrA = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int m = int.Parse(Console.ReadLine());
            int[] arrB = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] sumA = new int[n];
            sumA[0] = arrA[0];
            for (int i = 1; i < n; i++)
            {
                sumA[i] = sumA[i - 1] + arrA[i];
            }

            int[] sumB = new int[m];
            sumB[0] = arrB[0];
            for (int i = 1; i < m; i++)
            {
                sumB[i] = sumB[i - 1] + arrB[i];
            }

            ///////////////////////////////////////////////

            Dictionary<long, int> dictCountA = new Dictionary<long, int>();
            for (int i = 0; i < n; i++)
            {
                if (!dictCountA.ContainsKey(sumA[i]))
                    dictCountA.Add(sumA[i], 1);
                else
                    dictCountA[sumA[i]]++;
            }
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int temp = sumA[i] - sumA[j];
                    if (!dictCountA.ContainsKey(temp))
                        dictCountA.Add(temp, 1);
                    else
                        dictCountA[temp]++;
                }
            }

            Dictionary<long, int> dictCountB = new Dictionary<long, int>();
            for (int i = 0; i < m; i++)
            {
                if (!dictCountB.ContainsKey(sumB[i]))
                    dictCountB.Add(sumB[i], 1);
                else
                    dictCountB[sumB[i]]++;
            }
            for (int i = 1; i < m; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    int temp = sumB[i] - sumB[j];
                    if (!dictCountB.ContainsKey(temp))
                        dictCountB.Add(temp, 1);
                    else
                        dictCountB[temp]++;
                }
            }

            //----------------------------------------------
            long result = 0;
            foreach (var item in dictCountA)
            {
                if (dictCountB.ContainsKey(t - item.Key))
                {
                    result += (long)item.Value * dictCountB[t - item.Key];
                }
            }

            Console.WriteLine(result);
        }
    }
}