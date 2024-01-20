using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr) {
        List<int> list = new List<int>();
        foreach(int num in arr)
        {
            for(int i = 0; i < num; i++){
                list.Add(num);
            }
        }
        return list.ToArray();
    }
}