
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            (int, List<int>)[] arr = new (int, List<int>)[n + 1];
            for (int i = 1; i <= n; i++)
                arr[i].Item2 = new List<int>();
            arr[1].Item2.Add(1);
            for(int i = 2; i <= n; i++)
            {
                int num = arr[i - 1].Item1 + 1;
                List<int> list = new List<int>();
                int flag = 0;       //flag == 0, -1일때  ,  flag == 1, X2 일때, flag == 2, X3 일때
                if(i % 2 == 0 && num > arr[i / 2].Item1 + 1)
                {
                    flag = 1;
                    num = arr[i / 2].Item1 + 1;
                }
                if(i % 3 == 0 && num > arr[i / 3].Item1 + 1)
                {
                    flag = 2;
                    num = arr[i / 3].Item1 + 1;
                }
                switch (flag)
                {
                    case 0:
                        list = arr[i - 1].Item2.ToList();
                        break;
                    case 1:
                        list = arr[i / 2].Item2.ToList();
                        break;
                    case 2:
                        list = arr[i / 3].Item2.ToList();
                        break;
                }
                list.Add(i);
                arr[i] = (num, list);
            }
            Console.WriteLine(arr[n].Item1);
            Console.WriteLine(string.Join(' ', arr[n].Item2.OrderByDescending(x => x)));
        }
    }
}