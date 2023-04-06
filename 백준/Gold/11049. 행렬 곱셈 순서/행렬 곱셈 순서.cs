
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Matrix[,] arr = new Matrix[n, n];
            for(int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                arr[i, i] = new Matrix(0, int.Parse(input[0]), int.Parse(input[1]));
            }
            for(int i = 1; i < n; i++)
            {
                for(int j = 0; j < n - i; j++)
                {
                    //arr[j, j + i] = 
                    int minValue = int.MaxValue;
                    for(int k = j; k < j + i; k++)
                    {
                        minValue = Math.Min(minValue, arr[j, k].result + arr[k + 1, j + i].result + (arr[j, k].start * arr[j, k].end * arr[k + 1, j + i].end));
                    }
                    arr[j, j + i] = new Matrix(minValue, arr[j, j].start, arr[j + i, j + i].end);
                }
            }
            Console.WriteLine(arr[0, n - 1].result);
        }
        struct Matrix
        {
            public int result;
            public int start;
            public int end;
            public Matrix(int n, int start, int end)
            {
                this.result = n;
                this.start = start;
                this.end = end;
            }
        }
    }
}