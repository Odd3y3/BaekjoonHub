using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] strArr) {
        List<string> list = new List<string>();
        foreach (string s in strArr)
        {
            if(!s.Contains("ad"))
                list.Add(s);
        }
        return list.ToArray();
    }
}