using System;
using System.Linq;

public class Solution {
    public int solution(string num_str) {
        return num_str.Sum(x => x - '0');
    }
}