using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] num_list) {
        return num_list.OrderBy(x=>x).TakeLast(num_list.Length - 5).ToArray();
    }
}