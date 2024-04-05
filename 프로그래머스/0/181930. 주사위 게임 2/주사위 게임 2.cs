using System;

public class Solution {
    public int solution(int a, int b, int c) {
        int aa = a * a;
        int bb = b * b;
        int cc = c * c;
        int aaa = a * a * a;
        int bbb = b * b * b;
        int ccc = c * c * c;
        
        if(a == b && b == c)
            return (a + b + c) * (aa + bb + cc) * (aaa + bbb + ccc);
        else if(a == b || b == c || c == a)
            return (a + b + c) * (aa + bb + cc);
        else
            return a + b + c;
    }
}