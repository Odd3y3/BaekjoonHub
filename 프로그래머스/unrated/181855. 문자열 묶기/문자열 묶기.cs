using System;
using System.Linq;

public class Solution {
    public int solution(string[] strArr) {
        int[] counts = new int[31];
        foreach (string str in strArr){
            counts[str.Length]++;
        }
        return counts.Max();
    }
}