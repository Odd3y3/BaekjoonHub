using System;

public class Solution {
    public string solution(string[] my_strings, int[,] parts)
    {
        string result = "";
        
        for(int i = 0; i < parts.GetLength(0); i++)
        {
            result += my_strings[i].Substring(parts[i,0], parts[i,1] - parts[i,0] + 1);
        }
        
        return result;
    }
}