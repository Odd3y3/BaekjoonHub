using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string myString) {
        List<string> result = new List<string>();
        foreach(string s in myString.Split('x'))
        {
            if(s != "")
                result.Add(s);
        }
        
        result.Sort();
        return result.ToArray();
    }
}