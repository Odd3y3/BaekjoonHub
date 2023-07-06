
namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int test = int.Parse(Console.ReadLine());
            for(int t = 0; t < test; t++)
            {
                string[] input = Console.ReadLine().Split();
                int V = int.Parse(input[0]);
                int E = int.Parse(input[1]);
                bool[] visit = new bool[V + 1];
                List<int>[] graph = new List<int>[V + 1];
                for (int i = 1; i <= V; i++)
                    graph[i] = new List<int>();
                
                //graph 초기화 , input
                for(int i = 0; i < E; i++)
                {
                    input = Console.ReadLine().Split();
                    int u = int.Parse(input[0]);
                    int v = int.Parse(input[1]);
                    graph[u].Add(v);
                    graph[v].Add(u);
                }

                //progress
                bool isBG = true;
                bool[] flagList = new bool[V + 1];
                for(int i = 1; i <= V ; i++)
                {
                    if (!visit[i])
                    {
                        if(!Solve(i, graph, visit, true, flagList))
                        {
                            isBG = false;
                            break;
                        }
                    }
                }

                if (isBG)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }

        static bool Solve(int n, List<int>[] graph, bool[] visit, bool flag, bool[] flagList)
        {
            visit[n] = true;
            flagList[n] = flag;

            foreach (int node in graph[n])
            {
                if (visit[node])    //그 노드가 이미 방문 했엇다면
                {
                    if(flagList[node] == flag)
                    {
                        return false;
                    }
                }
                else                //처음 방문 하는거라면
                {
                    if (!Solve(node, graph, visit, !flag, flagList))
                        return false;
                }
            }

            return true;
        }
    }
}