using System;
using System.Collections.Generic;
using System.Linq;

namespace MyTestingField
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            for(int i = 0; i < t; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                int m = int.Parse(input[0]);
                int n = int.Parse(input[1]);
                int k = int.Parse(input[2]);
                bool[,] cabbage = new bool[m, n];
                int[,] cabbageIndex = new int[m, n];
                Dictionary<int, List<(int, int)>> dict = new Dictionary<int, List<(int, int)>>();

                int index = 1;
                int count = 0;

                for(int j = 0; j < k; j++)
                {
                    int[] point = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
                    cabbage[point[0], point[1]] = true;
                }
                for(int x = 0; x < m; x++)
                {
                    for(int y = 0; y < n; y++)
                    {
                        if (cabbage[x, y])
                        {
                            int up = y > 0 ? cabbageIndex[x, y - 1] : 0;
                            int left = x > 0 ? cabbageIndex[x - 1, y] : 0;
                            if (up == 0 && left == 0)
                            {
                                cabbageIndex[x, y] = index;
                                dict.Add(index, new List<(int, int)>());
                                dict[index].Add((x, y));
                                index++;
                                count++;
                            }
                            else if (up == 0)
                            {
                                cabbageIndex[x, y] = left;
                                dict[left].Add((x, y));
                            }
                            else if (left == 0)
                            {
                                cabbageIndex[x, y] = up;
                                dict[up].Add((x, y));
                            }
                            else if(left == up)
                            {
                                cabbageIndex[x, y] = up;
                                dict[up].Add((x, y));
                            }
                            else
                            {
                                int min = Math.Min(left, up);
                                int max = Math.Max(left, up);
                                cabbageIndex[x, y] = min;
                                dict[min].Add((x, y));
                                foreach(var item in dict[max])
                                {
                                    cabbageIndex[item.Item1, item.Item2] = min;
                                    dict[min].Add(item);
                                }
                                dict.Remove(max);
                                count--;
                            }
                        }
                    }
                }
                
                Console.WriteLine(count);
            }
        }
    }
}