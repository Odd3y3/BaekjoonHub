using System;

public class Solution {
    public int solution(string[] order) {
        int answer = 0;
        foreach (string str in order){
            if(str.Contains("cafelatte"))
                answer += 5000;
            else
                answer += 4500;
        }
        return answer;
    }
}