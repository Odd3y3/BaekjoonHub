using System;

public class Solution {
    public string solution(string code) {
        bool mode = false;
        string ret = string.Empty;
        for(int i = 0; i < code.Length; i++)
        {
            if (code[i] == '1')
            {
                mode = !mode;
                continue;
            }
            if ((!mode && i % 2 == 0) || (mode && i % 2 != 0))
            {
                ret += code[i];
            }
        }
        if(ret.Length == 0)
            ret = "EMPTY";
        return ret;
    }
}