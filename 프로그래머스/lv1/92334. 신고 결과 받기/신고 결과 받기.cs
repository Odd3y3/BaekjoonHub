using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        Dictionary<string, List<string>> reportDict = new Dictionary<string, List<string>>();
        Dictionary<string, int> reportedCount = new Dictionary<string, int>();
        List<string> reportedId = new List<string>();
        int[] result = new int[id_list.Length];

        foreach (string id in id_list)
        {
            reportDict.Add(id, new List<string>());
            reportedCount.Add(id, 0);
        }

        foreach (string s in report)
        {
            string[] id = s.Split(' ');
            if (!reportDict[id[0]].Contains(id[1]))
            {
                reportDict[id[0]].Add(id[1]);
                reportedCount[id[1]]++;
            }
        }

        foreach (var item in reportedCount)
        {
            if(item.Value >= k)
            {
                reportedId.Add(item.Key);
            }
        }

        foreach (string id in reportedId)
        {
            foreach (var item in reportDict)
            {
                if (item.Value.Contains(id))
                    result[Array.IndexOf(id_list, item.Key)]++;
            }
        }
        return result;
    }
}