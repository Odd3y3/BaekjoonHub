using System;

public class Solution {
    public string[] solution(string my_string) {
        string[] answer = new string[my_string.Length];
        for(int i = 0; i < my_string.Length; i++)
        {
            answer[i] = my_string.Substring(i, my_string.Length - i);
        }
        Array.Sort(answer);
        return answer;
    }
}