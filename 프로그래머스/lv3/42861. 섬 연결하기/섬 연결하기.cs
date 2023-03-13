using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[,] costs) {
        if(n == 1)
            return 0;
        List<KeyValuePair<int,int>>[] graph = new List<KeyValuePair<int, int>>[n + 1];
        for(int i = 0; i < n + 1; i++)
            graph[i] = new List<KeyValuePair<int, int>>();
        bool[] checkedNode = new bool[n + 1];
        for(int i = 0; i < costs.GetLength(0); i++)
        {
            graph[costs[i, 0] + 1].Add(new KeyValuePair<int, int>(costs[i, 1] + 1, costs[i, 2]));
            graph[costs[i, 1] + 1].Add(new KeyValuePair<int, int>(costs[i, 0] + 1, costs[i, 2]));
        }

        int answer = 0;
        int node, len;
        priorityQueue pq = new priorityQueue(n);
        pq.Enqueue(1, 0);
        while(pq.Count > 0)
        {
            KeyValuePair<int, int> keyValuePair = pq.Dequeue();
            if (!checkedNode[keyValuePair.Key])
            {
                answer += keyValuePair.Value;
                checkedNode[keyValuePair.Key] = true;
                foreach (var item in graph[keyValuePair.Key])
                {
                    pq.Enqueue(item.Key, item.Value);
                }
            }

        }
        return answer;
    }
}

public class priorityQueue
{
    public int Count;
    public KeyValuePair<int, int>[] arr;

    public priorityQueue(int n)
    {
        arr = new KeyValuePair<int, int>[((n - 1) * n) + 1];
        Count = 0;
    }

    public void Enqueue(int node, int priority)
    {
        Count++;
        arr[Count] = new KeyValuePair<int, int>(node, priority);
        int index = Count;
        while(index > 1)
        {
            if (arr[index].Value < arr[index / 2].Value)
            {
                KeyValuePair<int, int> temp = arr[index];
                arr[index] = arr[index / 2];
                arr[index / 2] = temp;
                index /= 2;
            }
            else break;
        }
    }
    public KeyValuePair<int, int> Dequeue()
    {
        KeyValuePair<int, int> resultValue = arr[1];
        arr[1] = arr[Count];
        Count--;
        int index = 1;
        while(index * 2 <= Count)
        {
            int minIndex = index * 2;
            if (index * 2 < Count && arr[index * 2].Value > arr[index * 2 + 1].Value)
                minIndex = index * 2 + 1;

            if (arr[index].Value > arr[minIndex].Value)
            {
                KeyValuePair<int, int> temp = arr[index];
                arr[index] = arr[minIndex];
                arr[minIndex] = temp;
                index = minIndex;
            }
            else
                break;
        }

        return resultValue;
    }
}