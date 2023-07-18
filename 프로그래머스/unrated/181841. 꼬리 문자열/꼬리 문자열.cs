using System;

public class Solution {
    public string solution(string[] str_list, string ex) {
        string answer = string.Empty;
        foreach (string item in str_list){
            if(!item.Contains(ex))
                answer += item;
        }
        return answer;
    }
}