using System;
using System.Linq;

public class Solution {
    public int solution(int[] rank, bool[] attendance) {
        for(int i = 0; i < rank.Length; i++)
        {
            if (!attendance[i])
            {
                rank[i] = int.MaxValue;
            }
        }

        int result = 0;

        for(int i = 2; i >= 0; i--)
        {
            int min = rank.Min();
            int index = Array.IndexOf(rank, min);
            result += index * (int)Math.Pow(100, i);
            rank[index] = int.MaxValue;
        }
        return result;
    }
}