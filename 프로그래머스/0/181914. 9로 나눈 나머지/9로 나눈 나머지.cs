using System;

public class Solution {
    public int solution(string number) {
        int answer = 0;
        foreach (char num in number)
        {
            answer += num - '0';
        }
        return answer % 9;
    }
}