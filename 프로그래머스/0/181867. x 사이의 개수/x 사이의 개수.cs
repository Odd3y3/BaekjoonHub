using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string myString) {
        List<int> result = new List<int>();
        int count = 0;
        foreach (char c in myString)
        {
            if(c == 'x')
            {
                result.Add(count);
                count = 0;
            }
            else
            {
                count++;
            }
        }
        result.Add(count);
        return result.ToArray();
    }
}