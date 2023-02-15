using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        List<int> list = new List<int>();
        foreach(string item in s.Split(' '))
            list.Add(Convert.ToInt32(item));
        return string.Concat(list.Min(), " ", list.Max());
    }
}