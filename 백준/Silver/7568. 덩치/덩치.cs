
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            (int, int)[] arr = new (int, int)[n];
            for(int i = 0; i < n; i++)
            {
                int[] temp = Console.ReadLine().Split().Select(int.Parse).ToArray();
                arr[i] = (temp[0], temp[1]);
            }

            int[] result = Enumerable.Repeat(1, n).ToArray();
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if(i != j)
                    {
                        if (arr[i].Item1 < arr[j].Item1 && arr[i].Item2 < arr[j].Item2)
                            result[i]++;
                    }
                }
            }
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
        }
    }
    
}