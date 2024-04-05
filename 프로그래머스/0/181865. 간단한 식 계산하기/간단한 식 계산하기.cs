using System;

public class Solution {
    public int solution(string binomial) {
        string[] arr = binomial.Split();
        int a = int.Parse(arr[0]);
        int b = int.Parse(arr[2]);
        switch(arr[1])
        {
            case "+":
                return a + b;
                break;
            case "-":
                return a - b;
                break;
            case "*":
                return a * b;
                break;
        }
        return 0;
    }
}