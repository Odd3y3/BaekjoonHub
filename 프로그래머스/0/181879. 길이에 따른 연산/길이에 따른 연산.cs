using System;
using System.Linq;

public class Solution {
    public int solution(int[] num_list) {
        if(num_list.Length >= 11)
            return num_list.Sum();
        else
        {
            int mul = 1;
            foreach(int num in num_list)
                mul *= num;
            return mul;
        }
    }
}