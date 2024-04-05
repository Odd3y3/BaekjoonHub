using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> result = new List<int>();
        while(n != 1)
        {
            result.Add(n);
            if(n % 2 == 0)
                n /= 2;
            else
                n = 3 * n + 1;
        }
        result.Add(1);
        return result.ToArray();
    }
}