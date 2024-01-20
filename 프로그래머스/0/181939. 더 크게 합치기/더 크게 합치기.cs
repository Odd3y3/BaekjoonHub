using System;

public class Solution {
    public int solution(int a, int b) {
        string s1 = a.ToString() + b.ToString();
        string s2 = b.ToString() + a.ToString();
        a = int.Parse(s1);
        b = int.Parse(s2);
        return a > b ? a : b;
    }
}