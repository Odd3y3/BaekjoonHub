
using System.Text;

namespace TestingField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for(int test = 0; test < c; test++)
            {
                Dictionary<string, int> dict = new Dictionary<string, int>();
                int count = 0;
                List<Queue<string>> queueList = new List<Queue<string>>();

                int f = int.Parse(Console.ReadLine());

                for(int i = 0; i < f; i++)
                {
                    string[] input = Console.ReadLine().Split();
                    bool is1Contain = dict.ContainsKey(input[0]);
                    bool is2Contain = dict.ContainsKey(input[1]);
                    if (!is1Contain && !is2Contain)
                    {
                        dict.Add(input[0], count);
                        dict.Add(input[1], count);
                        queueList.Add(new Queue<string>());
                        queueList[count].Enqueue(input[0]);
                        queueList[count].Enqueue(input[1]);
                        count++;
                    }
                    else if(is1Contain && !is2Contain)
                    {
                        dict.Add(input[1], dict[input[0]]);
                        queueList[dict[input[0]]].Enqueue(input[1]);
                    }
                    else if (!is1Contain && is2Contain)
                    {
                        dict.Add(input[0], dict[input[1]]);
                        queueList[dict[input[1]]].Enqueue(input[0]);
                    }
                    else
                    {
                        if (dict[input[0]] != dict[input[1]])
                        {
                            foreach(string s in queueList[dict[input[1]]])
                            {
                                dict[s] = dict[input[0]];
                                queueList[dict[input[0]]].Enqueue(s);
                            }
                        }
                    }
                    sb.AppendLine(queueList[dict[input[0]]].Count.ToString());
                }
            }

            Console.WriteLine(sb);
        }
    }
}