using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list, int n) {
        List<int> list = new List<int>();
        for(int i = n; i < num_list.Length; i++)
        {
            list.Add(num_list[i]);
        }
        
        for(int i = 0; i < n; i++){
            list.Add(num_list[i]);
        }
        
        return list.ToArray();
    }
}