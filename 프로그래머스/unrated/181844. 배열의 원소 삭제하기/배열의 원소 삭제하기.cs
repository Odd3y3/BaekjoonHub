using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int[] delete_list) {
        List<int> list = new List<int>();
        foreach (int i in arr)
        {
            if(!delete_list.Contains(i))
                list.Add(i);
        }
        return list.ToArray();
    }
}