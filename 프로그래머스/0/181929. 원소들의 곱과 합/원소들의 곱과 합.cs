using System;

public class Solution {
    public int solution(int[] num_list) {
        int mul = 1;
        int sum = 0;
        foreach(int num in num_list)
        {
            mul *= num;
            sum += num;
        }
        return mul < sum * sum ? 1 : 0;
    }
}