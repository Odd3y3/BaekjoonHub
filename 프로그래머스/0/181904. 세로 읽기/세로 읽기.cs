using System;

public class Solution {
    public string solution(string my_string, int m, int c) {
        string result = "";
        for(int i = c - 1; i < my_string.Length; i += m)
        {
            result += my_string[i];
        }
        return result;
    }
}