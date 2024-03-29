
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tc = int.Parse(Console.ReadLine());
            string[] input;
            for(int test = 0; test < tc; test++)
            {
                input = Console.ReadLine().Split();
                int n = int.Parse(input[0]);
                int m = int.Parse(input[1]);
                int w = int.Parse(input[2]);
                int a, b, c;
                Dictionary<int, int>[] edges = new Dictionary<int, int>[n + 1];
                for (int i = 1; i <= n; i++)
                    edges[i] = new Dictionary<int, int>();

                for(int i = 0; i < m; i++)
                {
                    input = Console.ReadLine().Split();
                    a = int.Parse(input[0]);
                    b = int.Parse(input[1]);
                    c = int.Parse(input[2]);
                    if (edges[a].ContainsKey(b))
                    {
                        if (edges[a][b] > c)
                            edges[a][b] = c;
                    }
                    else
                        edges[a].Add(b, c);

                    if (edges[b].ContainsKey(a))
                    {
                        if (edges[b][a] > c)
                            edges[b][a] = c;
                    }
                    else
                        edges[b].Add(a, c);
                }
                for(int i = 0; i < w; i++)
                {
                    input = Console.ReadLine().Split();
                    a = int.Parse(input[0]);
                    b = int.Parse(input[1]);
                    c = int.Parse(input[2]);
                    if (edges[a].ContainsKey(b))
                    {
                        if (edges[a][b] > -c)
                            edges[a][b] = -c;
                    }
                    else
                        edges[a].Add(b, -c);
                }

                //벨만포드
                bool result = true;
                bool[] visited = new bool[n + 1];
                for(int i = 0; i <= n; i++)
                {
                    visited[i] = false;
                }

                for (int start = 1; start <= n; start++)
                {
                    if (visited[start])
                        continue;
                    visited[start] = true;


                    int[] arr = new int[n + 1];
                    for (int i = 0; i <= n; i++)
                    {
                        arr[i] = 100000000;
                    }

                    arr[start] = 0;
                    //n - 1번 반복
                    for(int i = 0; i < n - 1; i++)
                    {
                        for(int j = 1; j <= n; j++)
                        {
                            foreach (var pair in edges[j])
                            {
                                if(arr[pair.Key] > arr[j] + pair.Value)
                                {
                                    visited[pair.Key] = true;
                                    arr[pair.Key] = arr[j] + pair.Value;
                                }
                            }
                        }
                    }

                    //한번 더 돌아서 같으면 NO, 다르면 YES
                    for (int j = 1; j <= n; j++)
                    {
                        foreach (var pair in edges[j])
                        {
                            if (arr[pair.Key] > arr[j] + pair.Value)
                            {
                                result = false;
                                break;
                            }
                        }
                        if (!result)
                            break;
                    }

                    if (!result)
                        break;
                }
                if (result)
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");
            }
        }
    }
}