using System;

public class Solution {
    public int[] solution(int[] arr) {
        int n = arr.Length;
        n = (int)Math.Pow(2, Math.Ceiling(Math.Log(n, 2)));
        int[] answer = new int[n];
        for(int i = 0; i < arr.Length; i++){
            answer[i] = arr[i];
        }
        
        return answer;
    }
}