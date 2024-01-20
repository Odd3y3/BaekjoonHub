using System;

public class Solution {
    public int solution(int[] numbers, int n) {
        int sum = 0;
        foreach(int num in numbers){
            if(sum > n)
                return sum;
            sum += num;
        }
        return sum;
    }
}