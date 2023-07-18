using System;

public class Solution {
    public int solution(int a, int b) {
        if(a % 2 != 0 && b % 2 != 0){
            return a * a + b * b;
        }
        else if(a % 2 == 0 && b % 2 == 0){
            return Math.Abs(a - b);
        }
        else
            return (a + b) * 2;
    }
}