using System;

public class Solution 
{
    public int solution(int n) 
    {
        
        int answer = n/7;
        if(n % 7 != 0) // n%7 나머지값이 0이 아닐때
        { 
            answer += 1; // +1해서 한판 추가
        }        
        return answer;
    }
}