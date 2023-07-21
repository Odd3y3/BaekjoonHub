using System;

public class Solution {
    public int solution(int[,] arr) {
        int n = arr.GetLength(0);
        int answer = 1;
        for(int i = 1; i < n; i++)
        {
            for(int j = 0; j < i; j++)
            {
                if (arr[i, j] != arr[j, i])
                    answer = 0;
            }
        }
        return answer;
    }
}