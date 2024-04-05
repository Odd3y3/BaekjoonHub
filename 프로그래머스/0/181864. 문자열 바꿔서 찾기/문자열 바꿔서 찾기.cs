using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string myString, string pat) {
        List<char> list = new List<char>();
        foreach (char c in myString)
        {
            if(c == 'A')
                list.Add('B');
            else
                list.Add('A');
        }
        return string.Join("", list).Contains(pat) ? 1 : 0;
    }
}