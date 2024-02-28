
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arrA = new int[n];
            int[] arrB = new int[n];
            int[] arrC = new int[n];
            int[] arrD = new int[n];
            for(int i = 0; i < n; ++i)
            {
                int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                arrA[i] = input[0];
                arrB[i] = input[1];
                arrC[i] = input[2];
                arrD[i] = input[3];
            }
            Dictionary<int, int> dict1 = new Dictionary<int, int>();
            Dictionary<int, int> dict2 = new Dictionary<int, int>();
            for (int i = 0; i < n; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    int value1 = arrA[i] + arrB[j];
                    int value2 = arrC[i] + arrD[j];
                    if (dict1.ContainsKey(value1))
                    {
                        dict1[value1]++;
                    }
                    else
                    {
                        dict1.Add(value1, 1);
                    }
                    if (dict2.ContainsKey(value2))
                    {
                        dict2[value2]++;
                    }
                    else
                    {
                        dict2.Add(value2, 1);
                    }
                }
            }

            long result = 0;
            foreach (var item in dict1)
            {
                int value = item.Key;
                int count = item.Value;
                if (dict2.ContainsKey(-value))
                    result += (long)count * dict2[-value];
            }

            Console.WriteLine(result);
        }
    }
}