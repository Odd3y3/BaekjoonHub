using System;
using System.Linq;

public class Solution {
    public int solution(int a, int b, int c, int d) {
        int pairNum = 0;
        int p = 0;
        int q = 0;
        if(a == b)
        {
            ++pairNum;
            if(p == 0)
                p = a;
            else if(p != a)
                q = a;
        }
        if(a == c)
        {
            ++pairNum;
            if(p == 0)
                p = a;
            else if(p != a)
                q = a;
        }
        if(a == d)
        {
            ++pairNum;
            if(p == 0)
                p = a;
            else if(p != a)
                q = a;
        }
        if(b == c)
        {
            ++pairNum;
            if(p == 0)
                p = b;
            else if(p != b)
                q = b;
        }
        if(b == d)
        {
            ++pairNum;
            if(p == 0)
                p = b;
            else if(p != b)
                q = b;
        }
        if(c == d)
        {
            ++pairNum;
            if(p == 0)
                p = c;
            else if(p != c)
                q = c;
        }
        
        if(pairNum == 6)
            return 1111 * a;
        else if(pairNum == 3)
        {
            int otherNum = 0;
            if(a != p)
                otherNum = a;
            else if(b != p)
                otherNum = b;
            else if(c != p)
                otherNum = c;
            else if(d != p)
                otherNum = d;
            return (10 * p + otherNum) * (10 * p + otherNum);
        }
        else if(pairNum == 2)
            return (p + q) * Math.Abs(p - q);
        else if(pairNum == 1)
        {
            int otherNum1 = 0;
            int otherNum2 = 0;
            if(a != p)
            {
                if(otherNum1 == 0)
                    otherNum1 = a;
                else
                    otherNum2 = a;
            }
            if(b != p)
            {
                if(otherNum1 == 0)
                    otherNum1 = b;
                else
                    otherNum2 = b;
            }
            if(c != p)
            {
                if(otherNum1 == 0)
                    otherNum1 = c;
                else
                    otherNum2 = c;
            }
            if(d != p)
            {
                if(otherNum1 == 0)
                    otherNum1 = d;
                else
                    otherNum2 = d;
            }
            return otherNum1 * otherNum2;
        }
        else
        {
            int[] list = {a, b, c, d};
            return list.Min();
        }
    }
}