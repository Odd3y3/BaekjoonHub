using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int lostCount = 0;

        List<int> reserveList = new List<int>(reserve);
        List<int> lostList = new List<int>(lost);

        reserveList.Sort();
        lostList.Sort();
        foreach (int item in lost)
        {
            if (reserveList.Contains(item))
            {
                lostList.Remove(item);
                reserveList.Remove(item);
            }
        }
        foreach (int item in lostList)
        {
            if (reserveList.Contains(item - 1))
            {
                reserveList.Remove(item - 1);
            }
            else if (reserveList.Contains(item + 1))
            {
                reserveList.Remove(item + 1);
            }
            else
                lostCount++;
        }
        return n - lostCount;
    }
}