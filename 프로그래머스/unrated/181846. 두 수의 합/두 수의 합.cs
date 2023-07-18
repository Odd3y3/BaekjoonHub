using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string a, string b) {
        Stack<int> stackA = new Stack<int>();
        Stack<int> stackB = new Stack<int>();

        foreach (char i in a)
            stackA.Push(i - '0');

        foreach (char i in b)
            stackB.Push(i - '0');


        Stack<int> result = new Stack<int>();
        int overNum = 0;
        while(stackA.Count > 0 || stackB.Count > 0 || overNum > 0)
        {
            int numA = 0;
            int numB = 0;
            if(stackA.Count > 0)
                numA = stackA.Pop();
            if(stackB.Count > 0)
                numB = stackB.Pop();

            int value = overNum + numA + numB;
            overNum = value / 10;
            result.Push(value % 10);
        }
        return string.Join("", result);
    }
}