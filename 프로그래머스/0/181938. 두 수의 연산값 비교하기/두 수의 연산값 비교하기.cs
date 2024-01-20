using System;

public class Solution {
    public int solution(int a, int b) {
        int n = int.Parse(a.ToString() + b.ToString());
        return n > 2 * a * b ? n : 2 * a * b;
    }
}