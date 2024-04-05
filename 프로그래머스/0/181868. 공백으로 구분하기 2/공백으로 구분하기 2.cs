using System;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_string) {
        List<string> list = new List<string>();
        foreach(var s in my_string.Split()){
            if(s.Length > 0){
                list.Add(s);
            }
        }
        
        return list.ToArray();
    }
}