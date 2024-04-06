using System;
using System.Linq;

public class Solution {
    public string solution(string my_string, int[] indices) {
        string answer = "";
        for(int i = 0; i < my_string.Length; i++)
        {
            if(!indices.Contains(i))
                answer += my_string[i];
        }
        return answer;
    }
}