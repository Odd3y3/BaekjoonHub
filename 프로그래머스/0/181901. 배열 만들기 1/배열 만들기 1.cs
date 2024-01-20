using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int k) {
        List<int> list = new List<int>();
        for(int i = k; i <= n; i += k)
        {
            list.Add(i);
        }
        return list.ToArray();
    }
}